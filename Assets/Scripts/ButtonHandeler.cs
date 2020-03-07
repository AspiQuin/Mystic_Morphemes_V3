using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandeler : MonoBehaviour
{

    public GameObject spellSlots;

    public void canvasReset()
    {
        Destroy(spellSlots.transform.Find("Slot1").GetComponent<SpellChoice>().chosenSpell);
        spellSlots.transform.Find("Slot1").GetComponent<SpellChoice>().isFilled = false;
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
