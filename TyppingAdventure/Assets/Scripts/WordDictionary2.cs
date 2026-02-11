using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordDictionary2 : MonoBehaviour
{
    public List<string> wordTextList = new List<string>();
    public List<WordControl2> wordPrefabList = new List<WordControl2>();
    public WordControl2 wordPrefab;
    public string fileOfWord;

    private Vector2 spawnPosition;
    private float spawnPositionX;
    private float spawnPositionY;

    private int wordPrefabListIndex = 0;

    void Start()
    {
        GetWordsFromFile();
        SpawnWord();
        
    }


    private void SpawnWord()
    {
        for(int wordTextCount = 0; wordTextCount < wordTextList.Count; wordTextCount++)
        {
            spawnPositionX = Random.Range(-6f,6.0f);
            spawnPositionY = 5f;
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
            return wordPrefabList[wordPrefabListIndex];
        }
        else
        {
            Debug.Log("Empty Words in List");
            return null;
        }
    }

    public void NextWordPrefab()
    {
        Debug.Log($"Word PrefabListIndex is {wordPrefabListIndex}. WordPreCou is {wordPrefabList.Count}");
        if(wordPrefabListIndex < wordPrefabList.Count)
        {
            wordPrefabList[wordPrefabListIndex].WordActive(false);
            wordPrefabListIndex++;

            // wordPrefabList[0].DestroyYouSelf();
            // wordPrefabList.RemoveAt(0);
        }
        else
        {
            
            Debug.Log("Empty Words in List");
        }
    }

    private void GetWordsFromFile()
    {
        fileOfWord = Path.Combine(Application.streamingAssetsPath,"vocabulary.txt");
        if (File.Exists(fileOfWord))
        {
            Debug.Log("File Of Words is already");
            string[] line = File.ReadAllLines(fileOfWord);
            for(int i =0; i < line.Length; i++)
            {
                wordTextList.Add(line[i]);
            }
            
        }
        else
        {
            Debug.Log("Can't Found File Of Words");
        }
    }

    
}
