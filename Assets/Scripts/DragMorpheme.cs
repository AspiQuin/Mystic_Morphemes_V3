using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMorpheme : MonoBehaviour
{
    bool isPicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = Camera.main.WorldToScreenPoint(Input.mousePosition);
        //transform.position = pos;

        

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

    //public void OnDrag(PointerEventData eventData)
    //{

    //    Debug.Log("test");
    //    var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    transform.position = position;
    //}
}
