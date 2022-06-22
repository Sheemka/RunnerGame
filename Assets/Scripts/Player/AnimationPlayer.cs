using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    public void Update()
    {
        animator.SetBool("IsGrounded", PlayerControls._isGrounded);
    }
}
