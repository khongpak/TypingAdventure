using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    // [SerializeField]private TextMeshPro textShow;
    // [SerializeField]private TextMeshPro word;
   
    // private int letterIndex = 0;
    // private int wordIndex = 0;
    // private string wordLetter;
    // private string mergeText;
    
    // public WordDictionary wordList;
    
    // void Start()
    // {
    //     wordList = FindAnyObjectByType<WordDictionary>();
    //     wordLetter = wordList.wordDictionary[wordIndex].text;
    //     textShow.text = word.text;

    // }

    // void Update()
    // {
    //    WordChecking();
    // }

    // private void WordChecking()
    // {
    //     if(wordIndex < wordList.wordDictionary.Count)
    //     { 
    //         Debug.Log("Word Index :" + wordIndex + " WordLetter :" + wordLetter + " LetterIndex :" + letterIndex);
    //         wordLetter = wordList.wordDictionary[wordIndex].text;
    //         if(letterIndex < wordList.wordDictionary[wordIndex].text.Count())
    //         {
    //             if(Input.inputString.Length > 0)
    //             {
    //                 foreach(char charector in Input.inputString)
    //                 {
                        
    //                     if(charector == wordLetter[letterIndex])
    //                     {
    //                         Debug.Log("Correct");
    //                         mergeText = $"<color=green>{wordLetter.Substring(0,letterIndex+1)}</color>{wordLetter.Substring(letterIndex+1)}";
    //                         letterIndex++;
    //                         textShow.text = mergeText;
    //                     }
    //                     else
    //                     {
    //                         Debug.Log("Wrong");
    //                     }

    //                 }
    //             }
    //         }
    //         else if(letterIndex == wordList.wordDictionary[wordIndex].text.Count())
    //         {
    //             wordIndex++;
    //             letterIndex = 0;
    //             if(wordIndex < wordList.wordDictionary.Count)
    //             {
    //                 textShow.text = wordList.wordDictionary[wordIndex].text;
    //             }
    //         }
    //     }
    // }
}
