using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string ScenGameOver; 

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "mort")
        {
            Destroy(this);
            SceneManager.LoadScene(ScenGameOver);
            Debug.Log("Game Over"); 

        }
    }

}
