using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public PlayerInput playerInput;
    public AgentAnimation animationManager;

    private void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
        animationManager = GetComponentInChildren<AgentAnimation>();
    }

    private void Start()
    {
        playerInput.OnMovement += HandleMovement;
    }

    private void HandleMovement(Vector2 input)
    {
        if (Mathf.Abs(input.x) > 0)
        {
            if (Mathf.Abs(rb2d.velocity.x) < 0.01f)
            {
                animationManager.PlayAnimation(AnimationType.run);
            }
            rb2d.velocity = new Vector2(input.x, 0) * 5;
        }
        else
        {
            if (Mathf.Abs(rb2d.velocity.x) > 0)
            {
                animationManager.PlayAnimation(AnimationType.idle);
            }
            rb2d.velocity = Vector2.zero;
        }


    }
}
