using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHitState : State
{
    protected override void EnterState()
    {
        agent.animationManager.PlayAnimation(AnimationType.hit);
        agent.animationManager.OnAnimationEnd.AddListener(TransitionToIdle);
    }

    protected override void HandleAttack()
    {
        //prevent
    }

    protected override void HandleJumpPressed()
    {
        //prevent
    }

    public override void StateUpdate()
    {
        //prevent
    }

    public override void GetHit()
    {
        //prevent
    }

    private void TransitionToIdle()
    {
        agent.animationManager.OnAnimationEnd.RemoveListener(TransitionToIdle);
        agent.TransitionToState(agent.stateFactory.GetState(StateType.Idle));
    }
}
