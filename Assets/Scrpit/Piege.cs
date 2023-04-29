using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege : MonoBehaviour
{
    public Material fullLife;
    public float timeLifePlaque;
    private float timeStartLifePlaque; 
    public GameObject plaque;

   

    [SerializeField]
    private bool playerCollider; 

    void Start()
    {
        playerCollider = false;
        timeStartLifePlaque = timeLifePlaque; 

    }

   
    void Update()
    {
        switch (playerCollider)
        {
            case true:
                timeLifePlaque -= Time.deltaTime;
                break;
            case false:
                timeLifePlaque = timeStartLifePlaque;
                break; 
        }
        if(timeLifePlaque <= 0)
        {
            Destroy(this.gameObject); 
        }
        

            
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            playerCollider = true; 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            playerCollider = false;
        }
    }
    


}
