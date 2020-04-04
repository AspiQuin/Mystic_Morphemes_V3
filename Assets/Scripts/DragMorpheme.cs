using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMorpheme : MonoBehaviour,  IPointerClickHandler
{
    //Variable dictating whether a tile has been selected
    bool isPicked;

    //saves the start position of the tile so it can return to its starting position
    Vector2 startPos;

    

    //spell Slots parent object
    GameObject spellSlots;

    //individual spell slot
    GameObject slot1;
    GameObject slot2;

    //the prefab to respawn a new tile
    public GameObject prefab;

    //A variable holding a value representing the chosen morpheme
    public int morpheme;

    // Start is called before the first frame update
    void Start()
    {
        

        //Initialize relevent variables
        spellSlots = gameObject.transform.parent.transform.Find("SpellSlots").gameObject;

        slot1 = spellSlots.transform.Find("Slot1").gameObject;
        slot2 = spellSlots.transform.Find("Slot2").gameObject;

        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{

        //}
        //Vector2 pos = Camera.main.WorldToScreenPoint(Input.mousePosition);
        //transform.position = pos;

        //if (Vector2.Distance(spellSlots.transform.position, transform.position) > 100)

        //Debug.Log(transform.position);
    }

    
    //private void OnMouseDrag()
    //{
    //    Debug.Log("test");

    //}

    //detects if I UI element is getting clicked on and dragged around
    //public void OnDrag(PointerEventData eventData)
    //{

    //    //Debug.Log("test");
    //    //check if the morpheme has already been picked for use
    //    if (!isPicked)
    //    {
    //        //set the position of the morpheme to the mouse position 
    //        var position = Input.mousePosition;
    //        transform.position = position;
    //    }
    //}

    //After the dragging of the UI element is finished run this code
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("test");

        //If an spell has not already been used
        //prevents duplicatioon bug
        if (!isPicked)
        {
            //Check that the distance from the spell slots is within a certain value

            Debug.Log("test");
            //If the first slot is not filled
            if (!slot1.GetComponent<SpellChoice>().isFilled)
            {

                //set the position of the selected object ot the spell slot 1 position
                transform.position = slot1.transform.position;

                //Set the slot data to the relevent variables
                slot1.GetComponent<SpellChoice>().isFilled = true;
                slot1.GetComponent<SpellChoice>().chosenSpell = gameObject;

                //create a new tile in the start position for the selected tile
                var newMorpheme = Instantiate(prefab, startPos, Quaternion.identity);

                //Prevent clone naming
                newMorpheme.name = gameObject.name;
                //set the new object to the UI parent and resize
                newMorpheme.transform.SetParent(gameObject.transform.parent);
                newMorpheme.transform.localScale = gameObject.transform.localScale;

                //Change the object scale to represent that it is selected and change its starting position to the spell slot
                gameObject.transform.localScale = new Vector2(1.5f, 1.5f);
                startPos = gameObject.transform.position;
                isPicked = true;
            }
            else if (!slot2.GetComponent<SpellChoice>().isFilled)
            {

                //set the position of the selected object ot the spell slot 2 position
                transform.position = slot2.transform.position;

                //Set the slot data to the relevent variables
                slot2.GetComponent<SpellChoice>().isFilled = true;
                slot2.GetComponent<SpellChoice>().chosenSpell = gameObject;

                //create a new tile in the start position for the selected tile
                var newMorpheme = Instantiate(gameObject, startPos, Quaternion.identity);

                //Prevent clone naming
                newMorpheme.name = gameObject.name;

                //set the new object to the UI parent and resize
                newMorpheme.transform.SetParent(gameObject.transform.parent);
                newMorpheme.transform.localScale = gameObject.transform.localScale;

                //Change the object scale to represent that it is selected and change its starting position to the spell slot
                gameObject.transform.localScale = new Vector2(1.5f, 1.5f);
                startPos = gameObject.transform.position;
                isPicked = true;
            }
            else
            {
                //Debug.Log("test");
                //return the object to the start position
                gameObject.transform.position = startPos;
            }
        }
        else
        {
            //Debug.Log("test");
            //return the object to the start position
            gameObject.transform.position = startPos;
        }
    }
}
