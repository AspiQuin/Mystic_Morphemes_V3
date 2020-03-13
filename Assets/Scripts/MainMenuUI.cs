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
        SceneManager.LoadScene("Room1");
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
}
