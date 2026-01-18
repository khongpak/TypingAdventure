using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;

public class GameManager : MonoBehaviour
{
    [SerializeField]private TextMeshPro textShow;
    [SerializeField]private TextMeshPro word;

    private int LetterIndex = 0;
    string wordLetter;
    private string mergeText;
    

    void Start()
    {
        wordLetter = word.text;
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
    }
}
