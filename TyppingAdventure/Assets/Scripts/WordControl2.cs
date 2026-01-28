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

    public void getTextWord(string textword)
    {
        text = textword;
    }
}
