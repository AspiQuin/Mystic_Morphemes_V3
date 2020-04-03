using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChanger : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void changeScene()
    {
        if (GameObject.Find("DontDestroy").GetComponent<Current>().wins == 3)
        {
            SceneManager.LoadScene("EndScene");
        }
        else
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
                    GameObject.Find("DontDestroy").GetComponent<Current>().wins ++;
                    SceneManager.LoadScene("MapScene");
                    break;
                case "FireTorchRoom1":
                    GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "Fire Column Room2";
                    SceneManager.LoadScene("Fire Column Room2");
                    break;
                case "Fire Column Room2":
                    GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "FireLavaRoom3";
                    SceneManager.LoadScene("FireLavaRoom3");
                    break;
                case "FireLavaRoom3":
                    GameObject.Find("DontDestroy").GetComponent<Current>().wins ++;
                    SceneManager.LoadScene("MapScene");
                    break;
                case "NatureDyingRoom1":
                    GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "NatureCritterRoom2";
                    SceneManager.LoadScene("NatureCritterRoom2");
                    break;
                case "NatureCritterRoom2":
                    GameObject.Find("DontDestroy").GetComponent<Current>().currentScene = "NatureTreeRoom3";
                    SceneManager.LoadScene("NatureTreeRoom3");
                    break;
                case "NatureTreeRoom3":
                    GameObject.Find("DontDestroy").GetComponent<Current>().wins ++;
                    SceneManager.LoadScene("MapScene");
                    break;   


                default:
                    Debug.Log("No Change: add new case");
                    break;

            }
        }
    }
    
}
