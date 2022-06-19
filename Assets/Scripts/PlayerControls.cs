using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] Button attack;
    [SerializeField] Button jump;
    [SerializeField] float jumpForce;

    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rigidBody.velocity = Vector2.up * jumpForce;
    }
}
