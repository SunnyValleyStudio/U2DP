using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        playerInput.OnMovement += HandleMovement;
    }

    private void HandleMovement(Vector2 input)
    {
        if (Mathf.Abs(input.x) > 0)
        {
            rb2d.velocity = new Vector2(input.x, 0) * 5;
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }


    }
}
