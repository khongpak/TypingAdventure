using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WordControl2 : MonoBehaviour
{
    private TextMeshPro word;
    private string text;
    [SerializeField]private float SpeedTextFall = 1f;
    private bool wordActive = false;

    private void Start()
    {
        gameObject.SetActive(false);
        word = GetComponent<TextMeshPro>();
        word.text = text;
        
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
        gameObject.SetActive(active);
        
    }

    public void SetSpeedUp(float speed)
    {
        SpeedTextFall += speed;
    }

    
}
