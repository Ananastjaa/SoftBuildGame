using UnityEngine;

public class RandColor : MonoBehaviour
{

    public bool IsMain = false, IsRight = false;

    private static Color _aColor;

    void Awake()
    {
        if (IsMain)
            _aColor = new Vector4(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 1);
    }

    void Start()
    {
        if (IsMain || IsRight)
            GetComponent<Renderer>().material.color = _aColor;
        else
            GetComponent<Renderer>().material.color = new Vector4(_aColor.r + Random.Range(0.1f, 0.3f), _aColor.g + Random.Range(0.1f, 0.3f), _aColor.b + Random.Range(0.1f, 0.3f), _aColor.a);
    }
}