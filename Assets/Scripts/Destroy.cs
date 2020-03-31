using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Awake()
    {        
        GameObject[] musdest = GameObject.FindGameObjectsWithTag("music_dest");
        if (musdest.Length > 1)
            Destroy (this.gameObject);
        
        GameObject[] mus = GameObject.FindGameObjectsWithTag("music");
        if (mus.Length == 1)
            Destroy (mus[0]);
        
        DontDestroyOnLoad(this.gameObject);
    }

}
