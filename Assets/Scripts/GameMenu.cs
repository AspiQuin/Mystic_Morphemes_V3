using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    //create the menu objects for when our pause is clicked
    public GameObject[] pauseObjects;
    public GameObject[] resumeObjects;

 
    // Start is called before the first frame update
    void Start()
    {
        //hide the buttons we do not need
        foreach(GameObject g in pauseObjects){
            g.SetActive(false);
        }
        foreach(GameObject g in resumeObjects){
            g.SetActive(true);
        }
        
        DontDestroyOnLoad(GameObject.Find("GameMenu"));
    }

    // Update is called once per frame
    void Update()
    {
        //Allows for a backup escape from the application
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    
    
    public void Pause() 
    {      
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
        
        foreach(GameObject g in resumeObjects)
        {
            g.SetActive(false);
        }
    }
    
    public void Resume()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
        foreach(GameObject g in resumeObjects)
        {
            g.SetActive(true);
        }
    }
    
    public void MainMenu()
    {
        //should incorporate a "are you sure you wish to proceed" option!!!
        SceneManager.LoadScene("Menu");
    }
    
    public void Compendium()
    {
        SceneManager.LoadScene("Compendium");
    }
    
    public void RestartRoom()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
