using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : MovementState
{
    public float jumpForce = 12;

    private bool jumpPressed = false;

    protected override void EnterState()
    {
        agent.animationManager.PlayAnimation(AnimationType.jump);
        movementData.currentVelocity = agent.rb2d.velocity;
        movementData.currentVelocity.y = jumpForce;
        agent.rb2d.velocity = movementData.currentVelocity;
        jumpPressed = true;
    }

    protected override void HandleJumpPressed()
    {
        jumpPressed = true;
    }

    protected override void HandleJumpReleased()
    {
        jumpPressed = false;
    }
}
