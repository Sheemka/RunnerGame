using UnityEngine;
//скрипт дл€ движени€ врагов в одном направлении
public class EnemiesMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _direction;
    private float _speed = 0.1f;

    private void FixedUpdate()
    {
        transform.Translate(_direction.normalized * _speed);
        if (_speed <= 0.5f)
        {
            _speed += Time.deltaTime / 300;
        }

        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
