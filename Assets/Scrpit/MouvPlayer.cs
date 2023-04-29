using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPlayer : MonoBehaviour
{
    public int speed;
    public int jumpForce;
   // public float gravity ;
   

    public CharacterController controller;
    public Rigidbody rb; 

   
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump"); 

        Vector3 direction = new Vector3(horizontal, 0f , vertical).normalized;
        Vector3 Vecjump = new Vector3(0f, jump, 0f).normalized;

       // direction.y -= gravity * Time.deltaTime;

       
            if ((direction.magnitude >= 0.1f)) // deplacement joueur 
            {
                float targetAngle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, targetAngle, 0);
                controller.Move(direction * Time.deltaTime * speed);
            }
        
       //direction.y -= gravity * Time.deltaTime;
        if (controller.isGrounded) // saut joueur 
        {            
           controller.Move(Vecjump * Time.deltaTime * jumpForce); 
        }
        Vector3 gravity = new Vector3(0, -9.81f, 0);
        float graviterMultiplier = 10f;
        gravity *= graviterMultiplier; 

        if(rb.velocity.y < 0 )
        {
            rb.AddForce(gravity); 
        }
       

    }
   
}
