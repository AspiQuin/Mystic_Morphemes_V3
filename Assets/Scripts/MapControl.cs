using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapControl : MonoBehaviour
{
    //the spell slot container
    public GameObject spellSlots;

    GameObject player;

    //the individual spell sleot variable declaration
    GameObject slot1;
    GameObject slot2;

    GameObject chosenPrefab;

    public ParticleSystem playerRisingPart;
    public ParticleSystem playerPulsePart;


    //What is the index of next level
    public int index;

    Vector3 spellPos = new Vector3(0, 3, 0);

    //string[,] array2Db = new string[5, 5] { { "one", "two" },
    //    { "three", "four" },
    //    { "five", "six" },
    //    { "one", "two" },
    //    { "three", "four" }};
                                           

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("living");

        //spellSlots = gameObject.transform.parent.transform.Find("SpellSlots").gameObject;
        slot1 = spellSlots.transform.Find("Slot1").gameObject;

        //slot1 = spellSlots.transform.Find("Slot1").gameObject;
        slot2 = spellSlots.transform.Find("Slot2").gameObject;

    }

        
    
    public void changeScene()
    {
        //add the conditions to change the scene
        if(slot1.GetComponent<SpellChoice>().isFilled == true && slot2.GetComponent<SpellChoice>().isFilled == true)
        {
            //SceneManager.LoadScene(index);

            switch (slot1.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme)
            {
                case 1:
                    if(slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Do Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("Fire");

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dodo)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dodo = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }
                        

                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Fire"), spellPos, Quaternion.identity);

                        //THIS WILL CHANGE SCENE ONE TO SCENE TWO
                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room1" || scene.name == "FireTorchRoom1"  || scene.name == "NatureTreeRoom3" || scene.name == "Room3")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                        }
                        
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Do Re
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;

                         GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dore = true;
                        
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Do Mi
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        spellPos.y = 2.25f;

                        Instantiate(GetComponent<PrefabController>().getPrefab("Lightning"), spellPos, Quaternion.identity);


                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().domi)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().domi = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Lightning");
                        
                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Lightning"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room1" || scene.name == "FireTorchRoom1"  || scene.name == "NatureTreeRoom3")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;  //The issue's here...
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Do Fa
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                        GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dofa = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Do So
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                        GameObject.Find("SpellsDone").GetComponent<DoneSpell>().doso = true;
                    }
                    break;
                    // ALL DO SPELLS DONE

                case 2:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Re Do
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Water"), spellPos, Quaternion.identity);
                        
                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().redo)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().redo = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Water");

                        //Should be activating scene change
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Water"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Fire Column Room2" || scene.name == "NatureDyingRoom1")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true; 
                        }

                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Re Re
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;

                        GameObject.Find("SpellsDone").GetComponent<DoneSpell>().rere = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Re Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);

                        Instantiate(GetComponent<PrefabController>().getPrefab("Ice"), spellPos, Quaternion.identity);

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().remi)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().remi = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Ice");

                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Ice"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true; 
                        }

                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Re Fa
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Snow"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().refa)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().refa = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Snow");
                        
                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Snow"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Fire Column Room2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true; 
                        }

                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Re So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        
                         GameObject.Find("SpellsDone").GetComponent<DoneSpell>().reso = true;
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    break;
                    //ALL RE SPELLS DONE

                case 3:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Mi Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mido)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mido = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Mi Re
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        
                         GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mire = true;

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Mi Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Rock"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mimi)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mimi = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Rock");

                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Rock"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room2" || scene.name == "FireLavaRoom3")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;  //The issue's here...
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Mi Fa
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");

                        player.GetComponent<PlayerMovement>().dudSpell = true;

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mifa)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mifa = true;
                            //playerPulsePart.Play();
                            //playerRisingPart.Play();
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Mi So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("Turtle?");
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().miso)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().miso = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }
                    }
                    break;
                    //ALL MI SPELLS DONE

                case 4:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Fa Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fado)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fado = true;
                            //playerPulsePart.Play();
                            //playerRisingPart.Play();
                        }

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Fa Re
                        Quaternion logQuaternion = new Quaternion();

                        logQuaternion.Set(-90, 90, 0, 1);

                        spellPos.y = 2.5f;
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Log"), spellPos, logQuaternion);

                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fare)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fare = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Log");
                        //turns scene 2 to scene 3
                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Fa Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fami)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fami = true;
                            //playerPulsePart.Play();
                            //playerRisingPart.Play();
                        }

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Fa Fa
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Fruit"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fafa)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fafa = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Fruit");

                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Fruit"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room3" || scene.name == "NatureCritterRoom2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true; 
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Fa So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Flower"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().faso)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().faso = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Flower");

                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Flower"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "NatureDyingRoom1")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                        }
                    }
                    break;


                case 5:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //So Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sodo)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sodo = true;
                            //playerPulsePart.Play();
                            //playerRisingPart.Play();
                        }

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //So Re
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Snake"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sore)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sore = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Snake");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //So Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().somi)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().somi = true;
                            //playerPulsePart.Play();
                            //playerRisingPart.Play();
                        }

                        player.GetComponent<PlayerMovement>().dudSpell = true;
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //So Fa
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        spellPos.y = 2.5f;

                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Bread"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sofa)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sofa = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }



                        Debug.Log ("Bread");
                        //turns scene 3 to end
                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room3" || scene.name == "NatureCritterRoom2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                           
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //So So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Critter"), spellPos, Quaternion.identity);
                        

                        if (!GameObject.Find("SpellsDone").GetComponent<DoneSpell>().soso)
                        {
                            GameObject.Find("SpellsDone").GetComponent<DoneSpell>().soso = true;
                            playerPulsePart.Play();
                            playerRisingPart.Play();
                        }

                        Debug.Log ("Critter");

                        //Should be changing scene 1 to scene 2...
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Critter"), spellPos, Quaternion.identity);

                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "NatureCritterRoom2")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;  //The issue's here...
                        }
                    }
                    break;
            }
                
        }
    }

    
}
