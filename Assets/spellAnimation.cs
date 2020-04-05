using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class spellAnimation : MonoBehaviour
{
    //set variables
    float destroyTimer;

    public bool changeScene;

    public GameObject puzzle;

    public GameObject player;

    public ParticleSystem embers;

    public bool permenent;

    bool once = true;
    // Start is called before the first frame update
    void Start()
    {
        //find needed game objects
        puzzle = GameObject.FindGameObjectWithTag("puzzlePiece");
        player = GameObject.FindGameObjectWithTag("living");

    }

    

    // Update is called once per frame
    void Update()
    {

        destroyTimer += Time.deltaTime;

        //Handles individule spell durentions and effects
        if(destroyTimer >= 5.0f)
        {
            Scene scene = SceneManager.GetActiveScene();
            if (!permenent)
            {
                Destroy(gameObject);
            }
            else
            {
                if(destroyTimer >= 13.5f)
                {
                    Destroy(gameObject);
                }
            }
            if (changeScene)
            {
                
                Destroy(puzzle);

                //sets the heights to stop at in the rooms
                if(scene.name == "Room3" || scene.name == "NatureTreeRoom3" )
                {
                    player.GetComponent<PlayerMovement>().stopHeight = 2.0f;

                }
                else if (scene.name == "FireLavaRoom3")
                {
                    player.GetComponent<PlayerMovement>().stopHeight = 3.0f;
                }
                else
                {
                    player.GetComponent<PlayerMovement>().stopHeight = 10.0f;

                }
                //runs once
                if(once)
                {
                    player.GetComponent<PlayerMovement>().walkFrw = true;

                    player.GetComponent<PlayerMovement>().changeScene = true;
                    once = false;
                }
                
                
            }
        }
    }
}
