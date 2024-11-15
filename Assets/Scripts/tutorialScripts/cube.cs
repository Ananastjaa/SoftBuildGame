using UnityEngine;

public class CubeFloat : MonoBehaviour
{

    [SerializeField] private float _speed, _tilt;
    private Vector3 _target = new Vector3(0, 1.6f, 0);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, Time.deltaTime * _speed);
        if (transform.position == _target && _target.y != 0.4f)
            _target.y = 0.4f;
        else if (transform.position == _target && _target.y == 0.4f)
            _target.y = 1.6f;

        transform.Rotate(Vector3.up * Time.deltaTime * _tilt);
    }
}
