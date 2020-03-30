using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellChoice : MonoBehaviour
{
    //set variables attached to the selected 
    public bool isFilled = false;

    public bool first = true;

    //Morpheme chosen
    public GameObject chosenSpell;

    public GameObject effect;

    float timer;

    float sinTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (isFilled && first)
        {
            effect.GetComponent<ParticleSystem>().Play();
            first = false;
        }
        sinTime = Mathf.Sin(timer * 5)*0.15f + 0.85f;
        if(isFilled)
        {
            //Debug.Log(sinTime);
            chosenSpell.GetComponent<Graphic>().color = new Color(sinTime, sinTime, sinTime);
        }
    }
}
