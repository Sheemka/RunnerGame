using UnityEngine;

public class startGameCamera : MonoBehaviour
{
    private Camera cam;
    private Animator animator;

    void Start()
    {
        cam = GetComponent<Camera>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
