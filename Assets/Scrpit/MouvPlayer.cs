using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPlayer : MonoBehaviour
{
    public float speed;
    public int jumpForce;
    private float gravity ;
    public float gravityForce; 
    public CharacterController controller;   

      
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
      

        gravity -= gravityForce * Time.deltaTime;       

        Vector3 direction = new Vector3(horizontal, 0f , vertical).normalized;
        Vector3 Vecjump = new Vector3(0f, jump, 0f).normalized;        

        if (direction.magnitude >= 0.1f) // deplacement joueur 
        {
            float targetAngle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);
            controller.Move(direction * Time.deltaTime * speed);
        }
        controller.Move(new Vector3(0f, gravity, 0f));
        if((controller.isGrounded))
        {
            gravity = 0;            
            controller.Move(Vecjump * Time.deltaTime * jumpForce);
           // controller.Move(direction * Time.deltaTime * speed);
        }
    }
    public void OnTrigger(Collider player)
    {
        if(player.transform.tag == "mur")
        {
            gravity = 0;
            Debug.Log("escalade "); 
        }
    }

}
