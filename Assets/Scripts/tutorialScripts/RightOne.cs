using UnityEngine;

public class RightOne : MonoBehaviour
{
    private GameObject mainCube;

    void Start()
    {
        mainCube = GameObject.Find("Main Cube");
    }

    void OnMouseDown()
    {
        SoundManag.PlaySound();
        if (GetComponent<Renderer>().material.color == mainCube.GetComponent<Renderer>().material.color)
            mainCube.GetComponent<GameCntrl>().next = true;
        else
            mainCube.GetComponent<GameCntrl>().lose = true;
    }
}