using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public WordDictionary2 wordDictionary2;
    void Start()
    {
        Debug.Log(wordDictionary2.wordTextList.Count);
        Debug.Log(wordDictionary2.wordTextList[0]);
    }
}
