using Unity.VisualScripting;
using UnityEngine;
using System;

public class SoundButtons : MonoBehaviour
{
    public static Action StopMusicButtPressed, StartMusicButtPressed;

    [SerializeField] private UnityEngine.UI.Image _soundButtImage, _musicButtImage;
    [SerializeField] private Sprite _soundOnSprite, _soundOffSprite, _musicOnSprite, _musicOffSprite;

    private static bool _IsSoundsOn;
    private static bool _IsMusicOn;

    public static bool IsSoundsOn => _IsSoundsOn;
    public static bool IsMusicOn => _IsMusicOn;

    private void Awake()
    {
        _IsSoundsOn = (PlayerPrefs.GetInt("SoundsOn") == 1) ? true : false;
        _IsMusicOn = (PlayerPrefs.GetInt("MusicOn") == 1) ? true : false;

        ChangeSoundButtSprite();
        ChangeMusicButtSprite();
    }

    public void SoundButtPressed()
    {
        _IsSoundsOn = !_IsSoundsOn;
        PlayerPrefs.SetInt("SoundsOn", Convert.ToInt32(_IsSoundsOn));
        ChangeSoundButtSprite();
    }

    public void MusicButtPressed()
    {
        _IsMusicOn = !_IsMusicOn;
        if (!_IsMusicOn) StopMusicButtPressed?.Invoke();
        else StartMusicButtPressed?.Invoke();
        PlayerPrefs.SetInt("MusicOn", Convert.ToInt32(_IsMusicOn));
        ChangeMusicButtSprite();
    }

    private void ChangeMusicButtSprite()
    {
        if (!_IsMusicOn) _musicButtImage.sprite = _musicOffSprite;
        else _musicButtImage.sprite = _musicOnSprite;
    }

    private void ChangeSoundButtSprite()
    {
        if (!_IsSoundsOn) _soundButtImage.sprite = _soundOffSprite;
        else _soundButtImage.sprite = _soundOnSprite;
    }

}
