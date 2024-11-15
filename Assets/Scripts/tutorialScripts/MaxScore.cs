using TMPro;
using UnityEngine;

public class MaxScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _bestScore;
    void Start()
    {
        _bestScore.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
