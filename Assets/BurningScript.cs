using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningScript : MonoBehaviour
{
    //[HideInInspector]
    public bool isBurning;

    bool burnt = false;

    public bool useParticles;

    float moveParticle;

    public float moveSpeed;

    public ParticleSystem particle;

    public float red;
    public float green;
    public float blue;
    float alpha = 1;

    public bool faded;

    Vector4 testColor = Color.white;

    Vector4 oColor;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void setEffect(Vector4 color, bool usePart)
    {
        red = color.x;
        blue = color.y;
        green = color.z;
        alpha = color.w;

        useParticles = usePart;
    }

    // Update is called once per frame
    void Update()
    {
        if(isBurning && !burnt)
        {
            //Debug.Log("test1");
            //particle.Play();
            if (useParticles)
            {
                //particle.startColor = Color.clear;
                particle.Play();
            }
            
            //particle = Instantiate(particle, transform.position, Quaternion.identity);
            //particle.transform.parent = gameObject.transform;

            burnt = true;

        }
        if(isBurning)
        {
            //Debug.Log("test2");

            moveParticle -= moveSpeed * Time.deltaTime;
            timer += Time.deltaTime;
            if(useParticles)
            {
                particle.transform.localPosition = new Vector2(0, 0.2f + moveParticle);
            }
            

            if(!particle.isEmitting)
            {
                //Debug.Log("test3");
                GetComponent<SpriteRenderer>().color = new Vector4(red, blue, green, alpha);
                if(faded && useParticles)
                {
                    alpha -= Time.deltaTime/2;
                }
                else if (faded)
                {
                    if(timer > 5)
                    {
                        alpha -= Time.deltaTime / 2;
                    }
                }

            }
            
            
        }
    }
}
