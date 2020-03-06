using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMorpheme : MonoBehaviour, IDragHandler, IEndDragHandler
{
    bool isPicked;
    Vector2 startPos;

    GameObject spellSlots;

    GameObject slot1;
    GameObject slot2;

    public GameObject prefab;


    public int morpheme;
    // Start is called before the first frame update
    void Start()
    {
        spellSlots = gameObject.transform.parent.transform.Find("SpellSlots").gameObject;

        slot1 = spellSlots.transform.Find("Slot1").gameObject;
        slot2 = spellSlots.transform.Find("Slot2").gameObject;

        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = Camera.main.WorldToScreenPoint(Input.mousePosition);
        //transform.position = pos;

        //if (Vector2.Distance(spellSlots.transform.position, transform.position) > 100)

        //Debug.Log(transform.position);
    }

    private void OnMouseEnter()
    {
        Debug.Log("test");
    }

    private void OnMouseDown()
    {
        Debug.Log(Input.mousePosition);
    }

    //private void OnMouseDrag()
    //{
    //    Debug.Log("test");

    //}

    private void OnMouseUp()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {

        //Debug.Log("test");
        if (!isPicked)
        {
            var position = Input.mousePosition;
            //isPicked = true;
            transform.position = position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Vector2.Distance(spellSlots.transform.position, transform.position) < 100)
        {
            Debug.Log("test");
            if (!slot1.GetComponent<SpellChoice>().isFilled)
            {
                transform.position = slot1.transform.position;
                slot1.GetComponent<SpellChoice>().isFilled = true;
                slot1.GetComponent<SpellChoice>().chosenSpell = gameObject;
                var newMorpheme = Instantiate(prefab, startPos, Quaternion.identity);
                newMorpheme.name = gameObject.name;
                newMorpheme.transform.parent = gameObject.transform.parent;
                newMorpheme.transform.localScale = gameObject.transform.localScale;
                gameObject.transform.localScale = new Vector2(2, 2);
                startPos = gameObject.transform.position;
                isPicked = true;
            }
            else if (!slot2.GetComponent<SpellChoice>().isFilled)
            {
                transform.position = slot2.transform.position;
                slot2.GetComponent<SpellChoice>().isFilled = true;
                slot2.GetComponent<SpellChoice>().chosenSpell = gameObject;
                var newMorpheme = Instantiate(gameObject, startPos, Quaternion.identity);
                newMorpheme.name = gameObject.name;
                newMorpheme.transform.parent = gameObject.transform.parent;
                newMorpheme.transform.localScale = gameObject.transform.localScale;
                gameObject.transform.localScale = new Vector2(2, 2);
                startPos = gameObject.transform.position;
                isPicked = true;
            }
            else
            {
                gameObject.transform.position = startPos;
            }
        }
        else
        {
            gameObject.transform.position = startPos;
        }
    }
}
