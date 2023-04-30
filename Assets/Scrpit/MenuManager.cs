using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuManager : MonoBehaviour
{
    public string Menu;
    public string Option;
    public string Jeux;


    public void PlayGame()
    {
        SceneManager.LoadScene(Jeux);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene(Menu); 
    }
    public void OptionScene()
    {
        SceneManager.LoadScene(Option);
    }
    public void QuiterGame()
    {
        Application.Quit(); 
    }
}
