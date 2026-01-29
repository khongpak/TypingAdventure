using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public WordDictionary2 wordDictionary2;
    public string myWord;
    
    private int letterIndex = 0;

    private void Start()
    {
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
        
        myWord = wordDictionary2.getWordPrefabList().getTextWord();
        letterIndex = 0;
        Debug.Log($"My word is {myWord}. It has {myWord.Count()} letters. My letterIndex is {letterIndex}");
    }
}
