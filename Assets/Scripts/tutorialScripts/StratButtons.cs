using UnityEngine;
using UnityEngine.SceneManagement;

public class StratButtons : MonoBehaviour
{
    [SerializeField] private GameObject _instPanel;
    public void StartButtPressed()
    {
        SoundManag.PlaySound();
        SceneManager.LoadScene(1);
    }

    public void AdButtPressed()
    {
        SoundManag.PlaySound();
        Application.OpenURL("http://youtube.com");
    }

    public void HomeButtPressed()
    {
        SoundManag.PlaySound();
        SceneManager.LoadScene(0);
    }

    public void InstButtPressed()
    {
        SoundManag.PlaySound();
        _instPanel.SetActive(true);
    }

    public void BackFrominsButtPressed()
    {
        SoundManag.PlaySound();
        _instPanel.SetActive(false);
    }
}
