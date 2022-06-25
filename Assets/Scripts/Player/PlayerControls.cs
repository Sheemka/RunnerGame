using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 8f;
    [SerializeField] private float _fallMultiplier = 1.5f;

    public static bool _isGrounded;

    private Rigidbody2D _rigidBody;

    public PlayerHPSP playerStats;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_rigidBody.velocity.y < 0)
        {
            _rigidBody.velocity += Vector2.up * Physics2D.gravity.y * _fallMultiplier * Time.deltaTime; //это для реалистичной анимации падения
        }
    }

    public void Jump() //прыжочек
    {
        if (_isGrounded)
        {
            _isGrounded = false;
            _rigidBody.velocity = new Vector2(0, _jumpForce);
        }
    }

    public void Attack() //пока что выключенная атака
    {
        playerStats.TakeStamina(30f);
    }

    private void OnCollisionEnter2D(Collision2D collision) //это для того, чтобы нельзя было прыгать в воздухе
    {
        if (collision.gameObject.tag == "ground")
        {
            _isGrounded = true;
        }  
    }
}
