using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private LayerMask maskplaque;
    public Piege piege; 
    
    void Start()
    {
        
    }

    
    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 10, Color.red);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 10, maskplaque))
        {
            piege.timeLifePlaque -= Time.deltaTime; 
        }
        if(piege.timeLifePlaque <= 0 )
        {
            piege.gameObject.SetActive(false); 
        }


    }
}
