using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public WordDictionary2 wordDictionary2;
    public string myWord;
    
    [SerializeField]private float delayTimeSpawn = 5f;

    private int letterIndex = 0;
    private string mergeText;
    private int wordIndex = 0;
    public bool nextWordNow = true;

    private void Start()
    {
        StartCoroutine(SpawnWord());
        NextWord();
        
    }

    private void Update()
    {
        WordChecking();
    }

    private void WordChecking()
    {
        
        if(letterIndex < myWord.Count())
        {
            //Debug.Log("Step1 Pass");
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
                        nextWordNow = true;
                    }
                    else
                    {
                        Debug.Log("Incorrect");
                    }
                }
            }

            if(letterIndex == myWord.Count() && wordIndex < wordDictionary2.wordPrefabList.Count-1)
            {
                wordDictionary2.NextWordPrefab();
                NextWord();
                wordIndex++;
                
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

    private IEnumerator SpawnWord()
    {
        Debug.Log($"Word PrefabList Count : {wordDictionary2.wordPrefabList.Count}");
        for(int i = 0; i < wordDictionary2.wordPrefabList.Count; i++){
            if(!nextWordNow){
                yield return new WaitForSeconds(delayTimeSpawn); 
            }
            else
            {
                nextWordNow = false;
                yield return new WaitForSeconds(0);
            }
            
            wordDictionary2.wordPrefabList[i].WordActive(true);
        }
    }
}
