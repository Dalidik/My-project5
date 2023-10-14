using UnityEngine;

public class CanvasController : MonoBehaviour
{

    [Header("Output")]
    public PlayerInputsManager inputs;

    public void VirtualMoveInput(Vector2 virtualMoveDirection)
    {
        inputs.move = virtualMoveDirection;
    }

   

    public void VirtualJumpInput(bool virtualJumpState)
    {
       inputs.jump = virtualJumpState;
    }

    
}