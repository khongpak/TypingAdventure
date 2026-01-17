using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;

public class GameManager : MonoBehaviour
{
    [SerializeField]private TextMeshPro textShow;
    [SerializeField]private TextMeshPro word;

    private int LetterIndex = 0;
    StringBuilder wordLetter;
    string allWord;

    void Start()
    {
        allWord = word.text;
        wordLetter = new StringBuilder(word.text);
        Debug.Log(wordLetter.Length);
        
    }

    void Update()
    {
        if(LetterIndex < word.text.Count()){
            if(Input.inputString.Length > 0)
            {
                foreach(char charector in Input.inputString)
                {
                    textShow.text = charector.ToString();
                    if(charector == word.text[LetterIndex])
                    {
                        Debug.Log("Correct");
                        allWord = "<color=green>"+allWord.Substring(0,LetterIndex+1) + "</color>" +
                                allWord.Substring(LetterIndex+1);
                        LetterIndex++;
                        word.text = allWord;
                        Debug.Log("Word Text :" + word.text[LetterIndex] + "LetterIndex is "+LetterIndex);
                    }
                    else
                    {
                        Debug.Log("Wrong");
                    }

                }
            }
        }
    }
}
