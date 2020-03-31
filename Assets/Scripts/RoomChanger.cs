using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChanger : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void changeScene()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Room1":
                GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "Room2";
                SceneManager.LoadScene("Room2");
                break;
            case "Room2":
                GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "Room3";
                SceneManager.LoadScene("Room3");
                break;
            case "Room3":
                SceneManager.LoadScene("EndScene");
                break;
            default:
                Debug.Log("No Change: add new case");
                break;

        }
        
    }
    
}
