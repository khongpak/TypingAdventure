using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    

    public WordDictionary2 wordDictionary2;
    public string myWord;
    public AudioManager playSound;
    
    [SerializeField]private float delayTimeSpawn = 5f;
    [SerializeField]private TextMeshProUGUI scoreShow;
    [SerializeField]private TextMeshProUGUI healthShow;

    private int letterIndex = 0;
    private string mergeText;
    private int wordIndex = 0;
    
    private int score = 0;
    private int health = 10;
    private int timeCountToReset;

    public bool nextWordNow = true;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        playSound.BGMSound(0);
        timeCountToReset = wordDictionary2.wordPrefabList.Count;
        StartCoroutine(SpawnWord());
        NextWord();
        
    }

    private void Update()
    {
        scoreShow.text = "Score : " + score;
        healthShow.text = "Health : " + health;
        WordChecking();
        
    }

    private void WordChecking()
    {
        
        if(letterIndex < myWord.Count())
        {
            if(Input.inputString.Length > 0)
            {
                foreach(char charector in Input.inputString)
                {
                    if(charector == myWord[letterIndex])
                    {
                        
                        mergeText = $"<color=green>{myWord.Substring(0,letterIndex+1)}</color>{myWord.Substring(letterIndex+1)}";
                        wordDictionary2.wordPrefabList[wordIndex].modifyTextWord(mergeText);
                        Debug.Log("Correct");
                        letterIndex++;
                        playSound.EffectSound(0);
                        
                        
                    }
                    else
                    {
                        Debug.Log("Incorrect");
                        score--;
                        playSound.EffectSound(1);
                    }
                }
            }

            if(letterIndex == myWord.Count() && wordIndex < wordDictionary2.wordPrefabList.Count-1)
            {
                wordDictionary2.NextWordPrefab();
                NextWord();
                wordIndex++;
                score++;
                timeCountToReset--;
                
                
            }else if((letterIndex == myWord.Count() && wordIndex == wordDictionary2.wordPrefabList.Count - 1) || timeCountToReset ==0)
            {
                ResetWords();
            }
        }
    }

    private void NextWord()
    {
        if(wordDictionary2.getWordPrefabList() != null)
        {
            myWord = wordDictionary2.getWordPrefabList().getTextWord();
            letterIndex = 0;
            Debug.Log($"My word is {myWord}. It has {myWord.Count()} letters. My letterIndex is {letterIndex}");
        }
    }

    private void ResetWords()
    {
        wordIndex = 0;
        timeCountToReset = wordDictionary2.wordPrefabList.Count;

        for(int i = 0; i < wordDictionary2.wordPrefabList.Count; i++)
        {
            mergeText = $"<color=black>{wordDictionary2.wordPrefabList[i].getTextWord()}</color>";
            wordDictionary2.wordPrefabList[i].modifyTextWord(mergeText);
            wordDictionary2.wordPrefabList[i].SetSpeedUp(0.1f);
        }

        wordDictionary2.NextWordPrefab();
        wordDictionary2.ResetWordPrefab();
        NextWord();
        StartCoroutine(SpawnWord());
    }


    private IEnumerator SpawnWord()
    {
        //Debug.Log($"Word PrefabList Count : {wordDictionary2.wordPrefabList.Count}");
        for(int i = 0; i < wordDictionary2.wordPrefabList.Count; i++){
            yield return new WaitForSeconds(delayTimeSpawn); 
            wordDictionary2.wordPrefabList[i].WordActive(true);
        }
    }

    public void DecreaseHealth()
    {
        health--;
        timeCountToReset--;
    }

    
}
