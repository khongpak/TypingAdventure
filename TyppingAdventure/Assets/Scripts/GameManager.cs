using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField]private TextMeshPro textShow;
    [SerializeField]private TextMeshPro word;
   
    private int LetterIndex = 0;
    private string wordLetter;
    private string mergeText;

    public WordDictionary wordList;
    

    void Start()
    {
        wordList = FindAnyObjectByType<WordDictionary>();
        wordLetter = word.text;
        Debug.Log(wordList.wordDictionary.Count);
        Debug.Log(wordList.wordDictionary[0].text);

    }

    void Update()
    {
        WordChecking();
    }

    private void WordChecking()
    {
        if(LetterIndex < word.text.Count()){
            if(Input.inputString.Length > 0)
            {
                foreach(char charector in Input.inputString)
                {
                    textShow.text = charector.ToString();
                    if(charector == wordLetter[LetterIndex])
                    {
                        Debug.Log("Correct");
                        mergeText = $"<color=green>{wordLetter.Substring(0,LetterIndex+1)}</color>{wordLetter.Substring(LetterIndex+1)}";
                        LetterIndex++;
                        textShow.text = mergeText;
                    }
                    else
                    {
                        Debug.Log("Wrong");
                    }

                }
            }
        }

        if(LetterIndex == word.text.Count())
        {
            Destroy(word);
        }
    }
}
