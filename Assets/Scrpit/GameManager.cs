using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time;
    public Text TimerText;
    public Image Fill;
    public float Max;

    public Image imageNiv;
    public float timeImage = 7f; 

    public GameObject player;

    public string ScenGameOver;
    public string Victoir;

   
    public int nombreMaison;
    public int maisonValide;

    int indexscene; 

    public SceneManager scene;

    public void Start()
    {
        indexscene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("on est dans la scene " + indexscene);
        imageNiv.enabled = true; 
    }



    void Update()
    {
       
        time -= Time.deltaTime;
        TimerText.text = "" + (int)time;
        Fill.fillAmount = time / Max;

        timeImage -= Time.deltaTime; 

        if(timeImage <= 0)
        {
            imageNiv.enabled = false;
            timeImage = 0; 
        }

        if(time <=0)
        {
            time = 0;   
            Destroy(player);
            SceneManager.LoadScene(ScenGameOver);
        }
        if(nombreMaison == maisonValide)
        {
            SceneManager.LoadScene(indexscene + 1 );
           
        }

    }
   
}
