using UnityEngine;
using TMPro;
using System.Linq;
public class GameManager : MonoBehaviour
{
    [SerializeField]private TextMeshPro textShow;
    [SerializeField]private TextMeshPro word;

    private int LetterIndex = 0;

    void Start()
    {
        Debug.Log(word.text.Count());
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
                        
                    }
                    else
                    {
                        Debug.Log("Wrong");
                    }
                    LetterIndex++;
                }
            }
        }
    }
}
