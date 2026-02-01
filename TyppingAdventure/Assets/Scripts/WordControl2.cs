using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WordControl2 : MonoBehaviour
{
    private TextMeshPro word;
    private string text;
    private float SpeedTextFall;
    private bool wordActive = false;

    private void Start()
    {
        word = GetComponent<TextMeshPro>();
        word.text = text;
        SpeedTextFall= Random.Range(0.2f,0.5f);
    }

    private void Update()
    {
        if(wordActive)
        {
            transform.position = new Vector2(transform.position.x,transform.position.y - SpeedTextFall * Time.deltaTime);
        }
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

    public void WordActive(bool active)
    {
        wordActive = active;
    }

    
}
