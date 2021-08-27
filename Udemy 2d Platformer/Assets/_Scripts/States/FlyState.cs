using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyState : MovementState
{
    protected Vector2 movementDirection;
    protected new void CalculateSpeed(Vector2 movementVector, MovementData movementData)
    {
        movementDirection = movementVector.normalized;
        if (movementVector.magnitude > 0)
        {
            movementData.currentSpeed += agent.agentData.acceleration * Time.deltaTime;
        }
        else
        {
            movementData.currentSpeed -= agent.agentData.deacceleration * Time.deltaTime;
        }
        movementData.currentSpeed = Mathf.Clamp(movementData.currentSpeed, 0, agent.agentData.maxSpeed);
    }

    protected new void CalculateVelocity()
    {
        CalculateSpeed(agent.agentInput.MovementVector, movementData);
        CalculateHorizontalDirection(movementData);
        movementData.currentVelocity = movementDirection * movementData.currentSpeed;
    }

    public override void StateUpdate()
    {
        CalculateVelocity();
        SetPlayerVelocity();
        //if (Mathf.Abs(agent.rb2d.velocity.x) < 0.01f)
        //{
        //    agent.TransitionToState(agent.stateFactory.GetState(StateType.Idle));
        //}
    }
}
