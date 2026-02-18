using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //public static AudioManager Instance;

    [SerializeField]private AudioSource[] typingSoundEffect;
    [SerializeField]private AudioSource[] bgmSound;

    void Start()
    {
        
    }

    public void EffectSound(int effectIndex)
    {
        typingSoundEffect[effectIndex].Play();
    }

    public void BGMSound(int bgmIndex)
    {
        bgmSound[bgmIndex].Play();
    }

    public void StopEffectSound(int effectIndex)
    {
        typingSoundEffect[effectIndex].Stop();
    }

     public void StopBGMSound(int bgmIndex)
    {
        bgmSound[bgmIndex].Stop();
    }
}
    
