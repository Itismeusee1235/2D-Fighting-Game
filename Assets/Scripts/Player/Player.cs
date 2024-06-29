using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine { get; private set; }
    public PlayerIdleState IdleState{ get; private set; }
    public PlayerMovingState MovingState {get; private set; }
    public PlayerInputHandeler PlayerInputHandeler { get; private set; }

    [SerializeField] private PlayerData playerData;

    public Animator animator { get; private set; }
    Rigidbody2D RB;


    private Vector2 workspace; // No need to make a new Vector 2 whenever we want to change vel
    public Vector2 currentVelocity { get; private set; }
    public int FacingDirection { get; private set; }

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();
        IdleState = new PlayerIdleState(this, StateMachine, playerData, "idle");
        MovingState = new PlayerMovingState(this, StateMachine, playerData, "move");

        FacingDirection = 1;
    }

    private void Start()
    {

        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        PlayerInputHandeler = GetComponent<PlayerInputHandeler>();
    
        StateMachine.Initialize(IdleState);


    }

    private void Update()
    {
        currentVelocity = RB.velocity;
        StateMachine.CurrentState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }

    public void SetVelocityX(float velocity)
    {
        workspace.Set(velocity, currentVelocity.y);
        RB.velocity = workspace;
        currentVelocity = workspace;
    }
    

    public void CheckIfShouldFlip(float xInput)
    {
        if (xInput != 0 && xInput != FacingDirection)
        {
            Flip();
        }
    }

    private void Flip()
    {
        FacingDirection *= -1;
        transform.Rotate(0f, 180f, 0f);
    }

}
