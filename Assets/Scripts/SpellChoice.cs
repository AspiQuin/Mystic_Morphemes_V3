using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellChoice : MonoBehaviour
{
    //set variables attached to the selected 
    public bool isFilled = false;

    public bool first = true;

    //Morpheme chosen
    public GameObject chosenSpell;

    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFilled && first)
        {
            effect.GetComponent<ParticleSystem>().Play();
            first = false;
        }
    }
}
