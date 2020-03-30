using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compendium : MonoBehaviour
{

    public GameObject[] pageone;
    public GameObject[] pagetwo;
    public GameObject[] pagethree;
    
    bool pageoneStatus;
    bool pagetwoStatus;
    bool pagethreeStatus;
    
    // Start is called before the first frame update
    void Start()
    {
    
        foreach(GameObject g in pageone){
            g.SetActive(true);
        }
        foreach(GameObject g in pagetwo){
            g.SetActive(false);
        }
        foreach(GameObject g in pagethree){
            g.SetActive(false);
        }
        pageoneStatus = true;
        pagetwoStatus = false;
        pagethreeStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BackButton()
    {
        //take the public current scene and reload it
        //Make use of Don'tDestroyOnLoad
        
    }
    
    public void LastPage()
    {
        //Obtain current page
        //Load Previous Page
        if (pageoneStatus == true)
        {
            //Do nothing lol
        }
        else if (pagetwoStatus == true)
        {
            //go back to page one
            foreach(GameObject g in pageone){
                g.SetActive(true);
            }
            foreach(GameObject g in pagetwo){
                g.SetActive(false);
            }
            
            pageoneStatus = true;
            pagetwoStatus = false;
            
        }
        else if (pagethreeStatus == true)
        {
            //go back to page two
            foreach(GameObject g in pagetwo){
                g.SetActive(true);
            }
            foreach(GameObject g in pagethree){
                g.SetActive(false);
            }
            
            pagethreeStatus = false;
            pagetwoStatus = true;
        }
        
    }
    
    public void NextPage()
    {
        //Obtain current page
        //Load previous page
        if (pageoneStatus == true)
        {
            //go forward to page two
            foreach(GameObject g in pageone){
                g.SetActive(false);
            }
            foreach(GameObject g in pagetwo){
                g.SetActive(true);
            }
            
            pageoneStatus = false;
            pagetwoStatus = true;
        }
        else if (pagetwoStatus == true)
        {
            //go forward to page three
            foreach(GameObject g in pagetwo){
                g.SetActive(false);
            }
            foreach(GameObject g in pagethree){
                g.SetActive(true);
            }
            
            pagetwoStatus = false;
            pagethreeStatus = true;
            
        }
        else if (pagethreeStatus == true)
        {
            //Do nothing; can't move forward from here
        }
        
    }
    
}
