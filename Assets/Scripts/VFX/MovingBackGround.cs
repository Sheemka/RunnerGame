using UnityEngine;

//идентичен движению пола
public class MovingBackGround : MonoBehaviour
{
    public float _speed;
    private float _backGroundSize;
    private float _backGroundPos;
    private Transform _backgroundTransform;

    private void Start()
    {
        _speed = 5f;
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
