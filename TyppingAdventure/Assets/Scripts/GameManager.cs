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
    
    private int letterIndex = 0;
    private string mergeText;

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
        //Debug.Log($"My letterIndex is {letterIndex}. My Word Count is {myWord.Count()}");
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
                        wordDictionary2.wordPrefabList[0].modifyTextWord(mergeText);
                        Debug.Log("Correct");
                        letterIndex++;
                    }
                    else
                    {
                        Debug.Log("Incorrect");
                    }
                }
            }

            if(letterIndex == myWord.Count())
            {
                wordDictionary2.NextWordPrefab();
                NextWord();
                
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
            yield return new WaitForSeconds(5f);
            wordDictionary2.wordPrefabList[i].WordActive(true);
        }
    }
}
