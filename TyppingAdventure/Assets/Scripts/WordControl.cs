using System.Linq;
using TMPro;
using UnityEngine;

public class WordControl : MonoBehaviour
{

    [SerializeField]private TextMeshPro wordText;

    private int letterIndex = 0;
    private string mergeText;
    private string wordLetter;

    void Start()
    {
        wordText = GetComponent<TextMeshPro>();
        wordText.text = WordDictionary.Instance.GetWord();
        Debug.Log(wordText.text);
        wordLetter = wordText.text;

    }

    void Update()
    {
        WordChecking();
    }

    private void WordChecking()
    {
        Debug.Log(WordDictionary.Instance.GetWordTarget());

        if(letterIndex < wordLetter.Count())
        {
            if(Input.inputString.Length > 0)
            {
                foreach(char charector in Input.inputString)
                {
                    if(charector == wordLetter[letterIndex])
                    {
                        Debug.Log("Correct");
                        mergeText = $"<color=green>{wordLetter.Substring(0,letterIndex+1)}</color>{wordLetter.Substring(letterIndex+1)}";
                        letterIndex++;
                        wordText.text = mergeText;
                        WordDictionary.Instance.IncreaseWordTarget();
                    }
                    else
                    {
                        Debug.Log("Wrong");
                    }
                }
            }

            if(letterIndex == wordLetter.Count())
            {
                Destroy(gameObject);
                
            }
        }
    }
}
