using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundState : PlayerState
{
    protected Vector2 input;
    public GroundState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        input = player.PlayerInputHandeler.MovementInput;
    }
}
