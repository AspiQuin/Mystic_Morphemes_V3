using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    public GameObject[] livingObjects;
    public GameObject[] deathObjects;
    public GameObject healthUI;

    public float timer = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject g in deathObjects){
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if  (healthUI.GetComponent<HealthDisplay>().health == 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {

                foreach (GameObject g in deathObjects)
                {
                    g.SetActive(true);
                }

                foreach (GameObject g in livingObjects)
                {
                    g.SetActive(false);
                }
            }
        }
    }
}
