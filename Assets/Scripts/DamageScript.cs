using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

    public GameObject healthUI;
    void takeDamage(int damage)
    {
        //this will contact the Player Health variable to reduce the number of hearts displayed


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            healthUI.GetComponent<HealthDisplay>().health -= 1;
        }
    }
    private void OnMouseDown()
    {
        
    }
}
