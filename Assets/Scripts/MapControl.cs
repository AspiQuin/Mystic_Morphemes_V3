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
            SceneManager.LoadScene(index);
        }
    }

    
}
