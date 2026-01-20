using UnityEngine;

public class WordTransform : MonoBehaviour
{
    [SerializeField]private Transform word;

    private void Start()
    {
        word.position = new Vector2(word.position.x + 1f ,word.position.y +10f);
    }
}
