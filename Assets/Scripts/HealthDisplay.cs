using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    //health of the player
    public int health = 3; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check each of the three hearts
       for(int i =0; i < 3; i++)
        {
            //if i is less than the health then set the health indicator to visible
            if(i < health)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
            //otherwise set the health indicator to invisible
            else
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
