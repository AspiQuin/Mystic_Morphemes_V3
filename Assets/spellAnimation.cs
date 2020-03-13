using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellAnimation : MonoBehaviour
{
    float destroyTimer;

    public bool changeScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyTimer += Time.deltaTime;

        if(destroyTimer >= 5.0f)
        {
            Destroy(gameObject);
            if(changeScene)
            {
                GetComponent<RoomChanger>().changeScene();
            }
        }
    }
}
