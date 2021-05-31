using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public State MoveState, ClimbState;

    protected override void EnterState()
    {
        agent.animationManager.PlayAnimation(AnimationType.idle);
        if (agent.groundDetector.isGrounded)
            agent.rb2d.velocity = Vector2.zero;
    }


    protected override void HandleMovement(Vector2 input)
    {
        if(agent.climbingDetector.CanClimb && Mathf.Abs(input.y) > 0)
        {
            agent.TransitionToState(ClimbState);
        }
        else if (Mathf.Abs(input.x) > 0)
        {
            agent.TransitionToState(MoveState);
        }
    }

}
