using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellAnimation : MonoBehaviour
{
    float destroyTimer;

    public bool changeScene;

    public GameObject puzzle;

    public GameObject player;

    public ParticleSystem embers;
    // Start is called before the first frame update
    void Start()
    {
        puzzle = GameObject.FindGameObjectWithTag("puzzlePiece");
        player = GameObject.FindGameObjectWithTag("living");
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
                Destroy(puzzle);

                player.GetComponent<PlayerMovement>().stopHeight = 10.0f;
                player.GetComponent<PlayerMovement>().walkFrw = true;

                player.GetComponent<PlayerMovement>().changeScene = true;
                
            }
        }
    }
}
