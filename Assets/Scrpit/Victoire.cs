using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Victoire : MonoBehaviour
{
    public int TimerVictoire;
    public int VictoireValid;  

    public bool CheckVictoire;

    public Collider maisonColl ;
    public GameObject maison;
        
    public int maisonValide = 0;
    public GameManager manager;

    public Animator AnimNinja;

    public void Start()
    {
        maison.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            CheckVictoire = true;
            AnimNinja.SetTrigger("Victory");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            CheckVictoire = false;
        }
    }
    
    private void Update()
    {
        switch (CheckVictoire)
        {
            case true:
                TimerVictoire += 1;
                break;
            case false:
                TimerVictoire = 0;
                break;
        }        

        if (TimerVictoire >= VictoireValid)
        {
            manager.maisonValide += 1;
            this.gameObject.SetActive(false);
            maison.SetActive(true);            
            CheckVictoire = false;
            TimerVictoire = 0;
        }
       
        
        
    }

}
