using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarryCreatureMoveState : PlayerParentState
{
    private Vector3             referenceVelocity;

    public PlayerCarryCreatureMoveState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animatorBoolName) : base(player, stateMachine, playerData, animatorBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        referenceVelocity = Vector3.zero;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        core.Movement.SmoothDampVelocityXY(player.GetTotalMoveSpeed() * xInput, player.GetTotalMoveSpeed() * yInput, player.GetTotalMoveSmoothing());

        if (!isExitingState) {
            if (xInput == 0 && yInput == 0) {
                stateMachine.ChangeState(player.CarryCreatureIdleState);
            } 
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}