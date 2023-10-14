using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputsManager : MonoBehaviour

{
    public bool jump;
    public Vector2 move;
   void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }
}


