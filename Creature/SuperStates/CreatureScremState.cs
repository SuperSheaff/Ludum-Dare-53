using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureScremState : CreatureState
{

    private float scremTimeElapsed;

    public CreatureScremState(Creature creature, CreatureStateMachine stateMachine, CreatureData creatureData, string animatorBoolName) : base(creature, stateMachine, creatureData, animatorBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();


        creature.SetCanBeFed(true);
        scremTimeElapsed = 0f;
        creature.creatureAudioManager.PlayAudio("CreatureSCREMv1");
    }

    public override void Exit()
    {
        base.Exit();

        creature.SetCanBeFed(false);
        creature.creatureAudioManager.StopAudio();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        core.Movement.SetVelocityZero();

        scremTimeElapsed += Time.deltaTime;

        if (scremTimeElapsed >= creatureData.scremDuration)
        {
            if (!isExitingState) 
            {
                stateMachine.ChangeState(creature.DeathState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
