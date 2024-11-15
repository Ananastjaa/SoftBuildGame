using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManag : MonoBehaviour
{
    private static AudioClip _click;
    private static AudioSource _audioSource;
    void Start()
    {
        _click = Resources.Load<AudioClip>("click2");
        _audioSource = GetComponent<AudioSource>();   
    }

    public static void PlaySound()
    {
        if(SoundButtons.IsSoundsOn) _audioSource.PlayOneShot(_click);
    }
}
