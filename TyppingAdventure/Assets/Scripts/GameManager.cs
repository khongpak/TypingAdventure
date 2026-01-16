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
        word.text = allWord.Substring(0,1);
        
        
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
                        wordLetter[LetterIndex] = 'X';
                        LetterIndex++;
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
