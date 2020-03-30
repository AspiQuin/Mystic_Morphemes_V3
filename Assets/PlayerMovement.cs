using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool walkFrw = true;

    public float moveSpeed;

    public float stopHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(walkFrw)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed*Time.deltaTime);
            Debug.Log(transform.position.y);
            if(transform.position.y > stopHeight)
            {
                walkFrw = false;
            }
            break;
        }
    }
}
