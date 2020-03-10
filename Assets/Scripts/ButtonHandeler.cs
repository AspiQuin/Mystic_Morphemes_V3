using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandeler : MonoBehaviour
{
    //Parent object of the spell slots
    public GameObject spellSlots;

    //Clear the objects in the spell slots
    public void canvasReset()
    {
        //Clear slot 1
        Destroy(spellSlots.transform.Find("Slot1").GetComponent<SpellChoice>().chosenSpell);
        spellSlots.transform.Find("Slot1").GetComponent<SpellChoice>().isFilled = false;

        //Clear Slot 2
        Destroy(spellSlots.transform.Find("Slot2").GetComponent<SpellChoice>().chosenSpell);
        spellSlots.transform.Find("Slot2").GetComponent<SpellChoice>().isFilled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        //spellSlots = gameObject.transform.parent.transform.Find("SpellSlots").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
