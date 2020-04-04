using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningScript : MonoBehaviour
{
    //[HideInInspector]
    public bool isBurning;

    bool burnt = false;

    float moveParticle;

    public float moveSpeed;

    public ParticleSystem particle;

    public float red;
    public float green;
    public float blue;
    float alpha = 1;

    public bool faded;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isBurning && !burnt)
        {
            //Debug.Log("test1");

            particle.Play();
            //particle = Instantiate(particle, transform.position, Quaternion.identity);
            //particle.transform.parent = gameObject.transform;

            burnt = true;

        }
        if(isBurning)
        {
            //Debug.Log("test2");

            moveParticle -= moveSpeed * Time.deltaTime;
            particle.transform.localPosition = new Vector2(0, 0.2f + moveParticle);

            if(!particle.isEmitting)
            {
                //Debug.Log("test3");
                GetComponent<SpriteRenderer>().color = new Vector4(red, green, blue, alpha);
                if(faded)
                {
                    alpha -= Time.deltaTime/2;
                }

            }
            
            
        }
    }
}
