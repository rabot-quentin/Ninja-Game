using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Victoire : MonoBehaviour
{
    public int TimerVictoire;
    public int VictoireValid;

    public string Victoir;

    public bool CheckVictoire;

   public GameObject[] victoires ;

    

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
            SceneManager.LoadScene(Victoir);
        }
        
    }

}
