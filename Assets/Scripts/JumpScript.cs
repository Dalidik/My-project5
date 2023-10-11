using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce;
     public void JumpBut()
     {
     
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0f, rigidbody.velocity.z);

        rigidbody.AddForce(transform.up * jumpForce , ForceMode.Impulse);
     }
}
