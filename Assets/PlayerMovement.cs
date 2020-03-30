using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool walkFrw = true;

    public float moveSpeed;

    public float stopHeight;

    public bool changeScene = false;

    float timer = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(walkFrw)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed*Time.deltaTime);
            //Debug.Log(transform.position.y);
            if(transform.position.y > stopHeight)
            {
                walkFrw = false;
            }
            if (changeScene)
            {
                timer -= Time.deltaTime;
                if(timer < 0)
                {
                    GetComponent<RoomChanger>().changeScene();
                }
            }
        }
    }
}
