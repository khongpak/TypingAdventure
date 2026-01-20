using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    [SerializeField]private TextMeshPro textShow;
    [SerializeField]private TextMeshPro word;
   
    private int letterIndex = 0;
    private int wordIndex = 0;
    private string wordLetter;
    private string mergeText;
    

    public WordDictionary wordList;
    

    void Start()
    {
        wordList = FindAnyObjectByType<WordDictionary>();
        //wordLetter = word.text;
        textShow.text = word.text;

    }

    void Update()
    {
        WordChecking();
    }

    private void WordChecking()
    {
        //Debug.Log("Word Index : " + wordIndex + "WordList :"+wordList.wordDictionary.Count);
        if(wordIndex < wordList.wordDictionary.Count)
        { 
            wordLetter = wordList.wordDictionary[wordIndex].text;
            if(letterIndex < wordList.wordDictionary[wordIndex].text.Count())
            {
                //Debug.Log("LetterIndex is :"+letterIndex+" WordList :" +wordList.wordDictionary[wordIndex].text.Count());
                Debug.Log(wordIndex);
                if(Input.inputString.Length > 0)
                {
                    foreach(char charector in Input.inputString)
                    {
                        textShow.text = charector.ToString();
                        if(charector == wordLetter[letterIndex])
                        {
                            Debug.Log("Correct");
                            mergeText = $"<color=green>{wordLetter.Substring(0,letterIndex+1)}</color>{wordLetter.Substring(letterIndex+1)}";
                            letterIndex++;
                            textShow.text = mergeText;
                        }
                        else
                        {
                            Debug.Log("Wrong");
                        }

                    }
                }
            }
            else if(letterIndex == word.text.Count())
            {
                wordIndex++;
                letterIndex = 0;
            }

        }
    }
}
