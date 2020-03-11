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

    //What is the index of next level
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        //spellSlots = gameObject.transform.parent.transform.Find("SpellSlots").gameObject;
        slot1 = spellSlots.transform.Find("Slot1").gameObject;

        //slot1 = spellSlots.transform.Find("Slot1").gameObject;
        slot2 = spellSlots.transform.Find("Slot2").gameObject;

    }

    private void Update()
    {
        //if the i key is pressed go to the menu
        if (Input.GetKeyDown("i"))
        {
            SceneManager.LoadScene(5);
        }
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
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Do Re
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Do Mi
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Do Fa
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Do So
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    break;


                case 2:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Re Do
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Re Re
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Re Mi
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Re Fa
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Re So
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    break;


                case 3:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Mi Do
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Mi Re
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Mi Mi
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Mi Fa
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Mi So
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    break;


                case 4:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //Fa Do
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //Fa Re
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //Fa Mi
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //Fa Fa
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //Fa So
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    break;


                case 5:
                    if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 1)
                    {
                        //So Do
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 2)
                    {
                        //So Re
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 3)
                    {
                        //So Mi
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 4)
                    {
                        //So Fa
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    else if (slot2.GetComponent<SpellChoice>().chosenSpell.GetComponent<DragMorpheme>().morpheme == 5)
                    {
                        //So So
                        Debug.Log(slot1.GetComponent<SpellChoice>().chosenSpell.name + " " + slot2.GetComponent<SpellChoice>().chosenSpell.name);
                    }
                    break;
            }
                
        }
    }

    
}
