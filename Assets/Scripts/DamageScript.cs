using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

    public GameObject healthUI;
    public void takeDamage(int damage)
    {
        //this will contact the Player Health variable to reduce the number of hearts displayed
        healthUI.GetComponent<HealthDisplay>().health -= damage;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //Hey I changed this to key down because every time I clicked was getting annoying, so press
    //    //H if you want health to go down
    //    if(Input.GetKeyDown(KeyCode.H))
    //    {
             
    //    }
    //}
    //private void OnMouseDown()
    //{
        
    //}
}
