using UnityEngine;

public class MusicManag : MonoBehaviour
{
    private AudioSource _audioSource;

    private void OnEnable()
    {
        SoundButtons.StopMusicButtPressed += StopMusic;
        SoundButtons.StartMusicButtPressed += StartMusic;
    }
    private void OnDisable()
    {
        SoundButtons.StopMusicButtPressed -= StopMusic;
        SoundButtons.StartMusicButtPressed -= StartMusic;
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.loop = true;
        if (SoundButtons.IsMusicOn) StartMusic();
        else StopMusic();
    }

    private void StopMusic()
    {
        _audioSource.Stop();
    }

    private void StartMusic()
    {
        _audioSource.Play();
    }
}