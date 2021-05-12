using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class State : MonoBehaviour
{
    [SerializeField]
    protected State JumpState, FallState;

    protected Agent agent;

    public UnityEvent OnEnter, OnExit;

    public void InitializeState(Agent agent)
    {
        this.agent = agent;
    }

    public void Enter()
    {
        this.agent.agentInput.OnAttack += HandleAttack;
        this.agent.agentInput.OnJumpPressed += HandleJumpPressed;
        this.agent.agentInput.OnJumpReleased += HandleJumpReleased;
        this.agent.agentInput.OnMovement += HandleMovement;
        OnEnter?.Invoke();
        EnterState();
    }

    protected virtual void EnterState()
    {

    }

    protected virtual void HandleMovement(Vector2 obj)
    {
    }

    protected virtual void HandleJumpReleased()
    {
    }

    protected virtual void HandleJumpPressed()
    {
        TestJumpTransition();
    }

    private void TestJumpTransition()
    {
        if (agent.groundDetector.isGrounded)
        {
            agent.TransitionToState(JumpState);
        }
    }

    protected virtual void HandleAttack()
    {
    }

    public virtual void StateUpdate()
    {
        TestFallTransition();
    }

    protected bool TestFallTransition()
    {
        if(agent.groundDetector.isGrounded == false)
        {
            agent.TransitionToState(FallState);
            return true;
        }
        return false;
    }

    public virtual void StateFixedUpdate()
    {

    }

    public void Exit()
    {
        this.agent.agentInput.OnAttack -= HandleAttack;
        this.agent.agentInput.OnJumpPressed -= HandleJumpPressed;
        this.agent.agentInput.OnJumpReleased -= HandleJumpReleased;
        this.agent.agentInput.OnMovement -= HandleMovement;
        OnExit?.Invoke();
        ExitState();
    }

    protected virtual void ExitState()
    {
    }
}
