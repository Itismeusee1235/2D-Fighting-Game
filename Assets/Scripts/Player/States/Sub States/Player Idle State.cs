using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : GroundState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.SetVelocityX(0f);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        Debug.Log(player.currentVelocity.x);

        if(player.currentVelocity.x != 0f )
        {
            //Debug.Log("Not 0" + player.currentVelocity.x);
            player.SetVelocityX(0f);
        }

        if(input.x != 0f)
        {
            stateMachine.ChangeState(player.MovingState);
        }
    }
}
