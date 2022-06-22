using UnityEngine;

public class MovingBackGround : MonoBehaviour
{
    private float _speed = 5f;
    private float _backGroundSize;
    private float _backGroundPos;
    private Transform _backgroundTransform;

    private void Start()
    {
        _backgroundTransform = GetComponent<Transform>();
        _backGroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        _backGroundPos -= _speed * Time.deltaTime;
        _backGroundPos = Mathf.Repeat(_backGroundPos, _backGroundSize);
        _backgroundTransform.position = new Vector3(_backGroundPos, 0, 5);
    }
}
