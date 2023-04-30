using UnityEngine;

public class MouvPlayer : MonoBehaviour
{
    public float speed;
    public int jumpForce;
    private float gravity ;
    public float gravityForce; 
    public CharacterController controller;
    
    public Animator AnimNinja;    

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 direction = new Vector3(horizontal, jump, vertical).normalized;
       


        


        gravity -= gravityForce * Time.deltaTime;
         controller.Move(new Vector3(0f, gravity, 0f));// application de la graviter 

        if ((controller.isGrounded))
        {
            if (direction.magnitude >= 0.1f) // deplacement joueur 
            {
                float targetAngle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, targetAngle, 0);
                controller.Move(direction * Time.deltaTime * speed);
            }
            gravity = 0;
            if (Input.GetButton("Jump"))
            {
                AnimNinja.SetTrigger("Jump");
            }
            

        }
        
        if (Input.GetButton("Horizontal")||Input.GetButton("Vertical"))
        {
            AnimNinja.SetBool("Run", true);
        }
        else
        {
            AnimNinja.SetBool("Run", false);
        }
    }
}
   

