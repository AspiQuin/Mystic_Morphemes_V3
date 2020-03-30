using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Current : MonoBehaviour
{

    public string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log(currentScene);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
