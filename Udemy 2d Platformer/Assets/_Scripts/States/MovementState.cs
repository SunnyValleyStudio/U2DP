using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    [SerializeField]
    protected MovementData movementData;
    public State IdleState;

    public float acceleration, deacceleration, maxSpeed;

    private void Awake()
    {
        movementData = GetComponentInParent<MovementData>();
    }

    protected override void EnterState()
    {
        agent.animationManager.PlayAnimation(AnimationType.run);

        movementData.horizontalMovementDirection = 0;
        movementData.currentSpeed = 0;
        movementData.currentVelocity = Vector2.zero;
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
        CalculateVelocity();
        SetPlayerVelocity();
        if(Mathf.Abs(agent.rb2d.velocity.x) < 0.01f)
        {
            agent.TransitionToState(IdleState, this);
        }
    }

    private void SetPlayerVelocity()
    {
        throw new NotImplementedException();
    }

    private void CalculateVelocity()
    {
        throw new NotImplementedException();
    }
}
