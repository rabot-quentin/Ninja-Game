using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoire : MonoBehaviour
{
    public int TimerVictoire;
    public int VictoireValid;

    public string Victoir;

    public bool CheckVictoire; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Maison")
        {
            CheckVictoire = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Maison")
        {
            CheckVictoire = false;
        }
    }
    private void Update()
    {
        if(CheckVictoire == true)
        {
            TimerVictoire += 1;            
        }else if(CheckVictoire == false)
        {
            TimerVictoire = 0; 
        }

        if (TimerVictoire >= VictoireValid)
        {
            SceneManager.LoadScene(Victoir);
        }
    }

}
