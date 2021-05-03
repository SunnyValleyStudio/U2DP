using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public PlayerInput agentInput;
    public AgentAnimation animationManager;
    public AgentRenderer agentRenderer;

    private void Awake()
    {
        agentInput = GetComponentInParent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
        animationManager = GetComponentInChildren<AgentAnimation>();
        agentRenderer = GetComponentInChildren<AgentRenderer>();
    }

    private void Start()
    {
        agentInput.OnMovement += HandleMovement;
        agentInput.OnMovement += agentRenderer.FaceDirection;
    }

    private void HandleMovement(Vector2 input)
    {
        if (Mathf.Abs(input.x) > 0)
        {
            if (Mathf.Abs(rb2d.velocity.x) < 0.01f)
            {
                animationManager.PlayAnimation(AnimationType.run);
            }
            rb2d.velocity = new Vector2(input.x * 5, rb2d.velocity.y);
        }
        else
        {
            if (Mathf.Abs(rb2d.velocity.x) > 0)
            {
                animationManager.PlayAnimation(AnimationType.idle);
            }
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }


    }
}
