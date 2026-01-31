using TMPro;
using UnityEngine;

public class WordControl2 : MonoBehaviour
{
    private TextMeshPro word;
    private string text;

    void Start()
    {
        word = GetComponent<TextMeshPro>();
        word.text = text;
    }

    public void setTextWord(string textword)
    {
        text = textword;
        
    }

    public string getTextWord()
    {
        return text;
    }

    public void modifyTextWord(string textInput)
    {
        word.text = textInput;
    }

    public void DestroyYouSelf()
    {
        Destroy(gameObject);
    }

    
}
