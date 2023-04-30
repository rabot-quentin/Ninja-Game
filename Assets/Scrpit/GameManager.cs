using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time;
    public Text TimerText;
    public Image Fill;
    public float Max;

    public GameObject player;

    public string ScenGameOver; 


    

    
    void Update()
    {
        time -= Time.deltaTime;
        TimerText.text = "" + (int)time;
        Fill.fillAmount = time / Max; 

        if(time <=0)
        {
            time = 0;   
            Destroy(player);
            SceneManager.LoadScene(ScenGameOver);
        }
    }
   
}
