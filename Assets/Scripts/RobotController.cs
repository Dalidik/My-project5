using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [SerializeField] float speed = 4;
    private PlayerInputsManager input;
    private CharacterController controller;

    [SerializeField] LayerMask groundLayer;
     [SerializeField] Transform groundCheck;
    bool isGrounded;
     [SerializeField] float jumpHeight = 2;
    [SerializeField] float gravity = -10f;
    Vector3 velocity;

    void Start()
    {
        input = GetComponent<PlayerInputsManager>();
        controller = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        JumpAndGravity();
    }

    private void Update()
    {
        Vector3 targetDirection = new Vector3(input.move.x, 0, input.move.y);

        controller.Move(targetDirection * speed * Time.deltaTime);
    }




    void JumpAndGravity()
    {

        

        isGrounded = Physics.CheckSphere(groundCheck.position, .2f, groundLayer);
        
        if(isGrounded )
        {
            if (input.jump)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * 2 * -gravity);
                input.jump = false;
            }
            
        }
        else
        {
           velocity.y += gravity * Time.deltaTime;
        }
        controller.Move(velocity * Time.deltaTime);
    }
}
