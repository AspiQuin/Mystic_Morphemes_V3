using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("MapScene");
    }
    
    public void Controls()
    {
         SceneManager.LoadScene("Controls");
    }
    
    public void ExitApp()
    {
        //Exits the application
        Application.Quit();
    }
    
    public void Credits()
    {
         SceneManager.LoadScene("Credits");
    }
    
    public void Back()
    {
         SceneManager.LoadScene("Menu");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("IntroTutorial");
    }

    public void Letter()
    {
        SceneManager.LoadScene("Context Scene");
    }
    
    public void FireDungeon()
    {
        SceneManager.LoadScene("FireTorchRoom1");
        GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "FireTorchRoom1";
    }
    
    public void NatureDungeon()
    {
        SceneManager.LoadScene("NatureDyingRoom1");
        GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "NatureDyingRoom1";
    }
    
    public void TrialDungeon()
    {
        SceneManager.LoadScene("Room1");
    }
}
