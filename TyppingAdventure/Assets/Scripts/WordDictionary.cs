using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WordDictionary : MonoBehaviour
{
   public static WordDictionary Instance;

   public List<TextMeshPro> wordDictionary;
   public List<String> words;

   private int wordIndex = 0;
   private int wordTarget = 0;

    void Awake()
    {
        Instance = this;
    }

    void Update()
   {
        Debug.Log(wordIndex);
   }

   public void IncreaseWordIndex()
   {
      wordIndex++;
   }

   public void IncreaseWordTarget()
   {
      wordTarget++;
   }

   public string GetWord()
   {
      return words[wordIndex];
   }

   public int GetWordTarget()
   {
      return wordTarget;
   }
   
}
