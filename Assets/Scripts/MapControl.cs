using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapControl : MonoBehaviour
{
    //the spell slot container
    public GameObject spellSlots;

    //the individual spell sleot variable declaration
    GameObject slot1;
    GameObject slot2;

    GameObject chosenPrefab;

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

                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Fire"), spellPos, Quaternion.identity);

                        //THIS WILL CHANGE SCENE ONE TO SCENE TWO
                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room1")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                        }
                        
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Do Re
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                        
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Do Mi
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Lightning"), spellPos, Quaternion.identity);

                        Debug.Log ("Lightning");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Do Fa
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Do So
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    break;


                case 2:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Re Do
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Water"), spellPos, Quaternion.identity);

                        Debug.Log ("Water");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Re Re
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Re Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);

                        Instantiate(GetComponent<PrefabController>().getPrefab("Ice"), spellPos, Quaternion.identity);

                        Debug.Log ("Ice");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Re Fa
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Snow"), spellPos, Quaternion.identity);

                        Debug.Log ("Snow");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Re So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    break;


                case 3:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Mi Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Mi Re
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Mi Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Rock"), spellPos, Quaternion.identity);

                        Debug.Log ("Rock");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Mi Fa
                       // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Mi So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("Turtle?");
                    }
                    break;


                case 4:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Fa Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Fa Re
                        Quaternion logQuaternion = new Quaternion();

                        logQuaternion.Set(-90, 90, 0, 1);

                        spellPos.y = spellPos.y - 0.5f;
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Log"), spellPos, logQuaternion);

                        
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
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Fa Fa
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Fruit"), spellPos, Quaternion.identity);

                        Debug.Log ("Fruit");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Fa So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Flower"), spellPos, Quaternion.identity);

                        Debug.Log ("Flower");
                    }
                    break;


                case 5:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //So Do
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //So Re
                        // Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Snake"), spellPos, Quaternion.identity);

                        Debug.Log ("Snake");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //So Mi
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Debug.Log ("NULL");
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //So Fa
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        chosenPrefab = Instantiate(GetComponent<PrefabController>().getPrefab("Bread"), spellPos, Quaternion.identity);

                        Debug.Log ("Bread");
                        //turns scene 3 to end
                        Scene scene = SceneManager.GetActiveScene();
                        if (scene.name == "Room3")
                        {
                            chosenPrefab.GetComponent<spellAnimation>().changeScene = true;
                           
                        }
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //So So
                        //Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                        Instantiate(GetComponent<PrefabController>().getPrefab("Critter"), spellPos, Quaternion.identity);

                        Debug.Log ("Critter");
                    }
                    break;
            }
                
        }
    }

    
}
