using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandeler : MonoBehaviour
{
    public Vector2 MovementInput { get; private set; }
    public float JumpTimer { get; private set; }

    void Start()
    {
        JumpTimer = 0;
    }

    void Update()
    {
        JumpTimer -= Time.deltaTime;
        MovementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpTimer = 10f;
        }

    }
}
