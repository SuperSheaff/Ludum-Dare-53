using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureEatState : CreatureState
{

    public CreatureEatState(Creature creature, CreatureStateMachine stateMachine, CreatureData creatureData, string animatorBoolName) : base(creature, stateMachine, creatureData, animatorBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        creature.creatureAudioManager.PlayAudio("CreatureEatingMelonv1");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        core.Movement.SetVelocityZero();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void AnimationFinishedTrigger()
    {
        base.AnimationFinishedTrigger();

        creature.SetMood(creature.GetMood() + creatureData.MelonMoodBoost);
        stateMachine.ChangeState(creature.IdleState);
    }

}
