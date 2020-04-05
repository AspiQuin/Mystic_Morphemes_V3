using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;

    public bool walkFrw = true;

    public bool dudSpell = false;

    public float moveSpeed;

    public float stopHeight;

    public bool changeScene = false;

    float timer = 6.0f;

    float delay = 0.5f;

    public GameObject health;


    float counter;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player is dead play death animation
        if(health.GetComponent<HealthDisplay>().health <= 0)
        {
            animator.SetBool("dead", true);
        }

        if(dudSpell)
        {
            counter += Time.deltaTime;
            if(counter > 1)
            {
                dudSpell = false;
                counter = 0;
            }
        }

        //comunicates with the animator
        animator.SetBool("walking", walkFrw);

        animator.SetBool("dud", dudSpell);

        //moves player
        if (walkFrw)
        {
            delay -= Time.deltaTime;
            if (delay < 0)
            {
                //animator.SetBool("walking", walkFrw);
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
                //Debug.Log(transform.position.y);
                if (transform.position.y > stopHeight)
                {
                    walkFrw = false;
                    delay = 1.5f;
                }
                
            }
        }
        if (changeScene)
        {
            //Debug.Log("changeScene");
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                GetComponent<RoomChanger>().changeScene();
            }
        }
    }
}
