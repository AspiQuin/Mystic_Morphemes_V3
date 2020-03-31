using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {   
        GameObject[] mus = GameObject.FindGameObjectsWithTag("music");
        if (mus.Length > 1)
            Destroy (this.gameObject);
        
        GameObject[] musdest = GameObject.FindGameObjectsWithTag("music_dest");
        if (musdest.Length == 1)
            Destroy (musdest[0]);
        
        DontDestroyOnLoad(this.gameObject);
    }

}
