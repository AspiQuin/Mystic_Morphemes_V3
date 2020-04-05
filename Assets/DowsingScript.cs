using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DowsingScript : MonoBehaviour
{
    public bool isDowsing;

    bool putOut = false;

    //float moveParticle;

    public float changeSpeed;

    //public ParticleSystem particle;

    public GameObject spawn;
    public GameObject damage;

    public float red;
    public float green;
    public float blue;
    float alpha = 1;

    int count = 0;

    float timer = 5.0f;

    public bool shrinks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDowsing && !putOut)
        {
            //Debug.Log("test1");

            //particle.Play();
            //particle = Instantiate(particle, transform.position, Quaternion.identity);
            //particle.transform.parent = gameObject.transform;

            putOut = true;

        }
        
        if (isDowsing && count < 3)
        {
            timer -= Time.deltaTime;
            //Debug.Log("test2");

            //transform.localScale -= transform.localScale * changeSpeed * Time.deltaTime;
            //particle.transform.localPosition = new Vector2(0, 0.2f + moveParticle);

            //if (!particle.isEmitting)
            //{
            //    //Debug.Log("test3");
            //    GetComponent<SpriteRenderer>().color = new Vector4(red, green, blue, alpha);
            if (shrinks && timer > 0)
            {
                transform.localScale -= transform.localScale * changeSpeed * Time.deltaTime;
                //alpha -= Time.deltaTime / 2;
            }
            else
            {
                count += 1;
                isDowsing = false;
                putOut = false;
                timer = 5.0f;
            }
        } 
        else if (isDowsing)
        {
            damage.GetComponent<DamageScript>().takeDamage(1);
            isDowsing = false;
        }
            //}


        
        
    }
}