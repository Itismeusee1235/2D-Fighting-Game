using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : GroundState
{
    public PlayerMovingState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        player.CheckIfShouldFlip(input.x);

        player.SetVelocityX(playerData.movementVelocity * input.x);

        if(input.x == 0f)
        {
            stateMachine.ChangeState(player.IdleState);
        }
    }
}
