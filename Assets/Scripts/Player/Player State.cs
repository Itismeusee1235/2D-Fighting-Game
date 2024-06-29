using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    protected PlayerData playerData;
    protected PlayerStateMachine stateMachine;
    string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerData = playerData;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        player.animator.SetBool(animBoolName, true);
       // Debug.Log(animBoolName);
        DoChecks();
    }

    public virtual void Exit()
    {
        player.animator.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {
        DoChecks();
    }

    public virtual void PhysicsUpdate()
    {

    }

    public virtual void DoChecks()
    {

    }
    
}
