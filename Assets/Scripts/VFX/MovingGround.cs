using UnityEngine;
//����� ������ ������ ��� �� ������������ �����, ����� ���� �������� ���
public class MovingGround : MonoBehaviour
{
    public float _speed;
    private float _GroundSize;
    private float _GroundPos;
    private Transform _groundTransform;

    private void Start()
    {
        _speed = 5f;
        _groundTransform = GetComponent<Transform>();
        _GroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        _GroundPos -= _speed * Time.deltaTime;
        _GroundPos = Mathf.Repeat(_GroundPos, _GroundSize);
        _groundTransform.position = new Vector3(_GroundPos, transform.position.y, 0);
    }
}
