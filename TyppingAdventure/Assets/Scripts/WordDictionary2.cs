using System.Collections.Generic;
using UnityEngine;

public class WordDictionary2 : MonoBehaviour
{
    public List<string> wordTextList = new List<string>();
    public List<WordControl2> wordPrefabList = new List<WordControl2>();
    public WordControl2 wordPrefab;



    private Vector2 spawnPosition;
    private float spawnPositionX;
    private float spawnPositionY;

    void Start()
    {
        SpawnWord();
        
    }


    private void SpawnWord()
    {
        for(int wordTextCount = 0; wordTextCount < wordTextList.Count; wordTextCount++)
        {
            spawnPositionX = Random.Range(-5.0f,5.0f);
            spawnPositionY = Random.Range(6f,7f);
            spawnPosition = new Vector2(spawnPositionX,spawnPositionY);

            WordControl2 wordText = Instantiate(wordPrefab,spawnPosition,transform.rotation);
            wordText.name = "Word:"+wordTextList[wordTextCount];
            wordText.setTextWord(wordTextList[wordTextCount]);
            wordPrefabList.Add(wordText);
            
            
        }
    }
    public WordControl2 getWordPrefabList()
    {
        if(wordPrefabList.Count > 0)
        {
            return wordPrefabList[0];
        }
        else
        {
            Debug.Log("Empty Words in List");
            return null;
        }
    }

    public void NextWordPrefab()
    {
        if(wordPrefabList.Count > 0)
        {
            wordPrefabList[0].DestroyYouSelf();
            wordPrefabList.RemoveAt(0);
        }
        else
        {
            Debug.Log("Empty Words in List");
        }
    }

    
}
