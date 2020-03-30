using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Compendium : MonoBehaviour
{

    public GameObject[] pageone;
    public GameObject[] pagetwo;
    public GameObject[] pagethree;
    
    bool pageoneStatus;
    bool pagetwoStatus;
    bool pagethreeStatus;
    
   // public Scene sceneString;
    
    
    // Start is called before the first frame update
    void Start()
    {
    
        //DontDestroyOnLoad(this.gameObject);
    
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
        SceneManager.LoadScene(GameObject.Find("DontDestroy").GetComponent<Current>().currentScene);
        
        Destroy(GameObject.Find("DontDestroy"));
            
    }
    
    public void LastPage()
    {
        //Obtain current page
        //Load Previous Page
        if (pageoneStatus == true)
        {
            //Do nothing lol
            //Checking for Do Spells
            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dodo == true)
            {
                GameObject.Find("DoDo").GetComponent<Text>().text = "Do + Do = fire!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dore == true)
            {
                GameObject.Find("DoRe").GetComponent<Text>().text = "Do + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().domi == true)
            {
                GameObject.Find("DoMi").GetComponent<Text>().text = "Do + Mi = lightning!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dofa == true)
            {
                GameObject.Find("DoFa").GetComponent<Text>().text = "Do + Fa = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().doso == true)
            {
                GameObject.Find("DoSo").GetComponent<Text>().text = "Do + So = null...";
            }
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
            
            //Checking for Do Spells
            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dodo == true)
            {
                GameObject.Find("DoDo").GetComponent<Text>().text = "Do + Do = fire!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dore == true)
            {
                GameObject.Find("DoRe").GetComponent<Text>().text = "Do + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().domi == true)
            {
                GameObject.Find("DoMi").GetComponent<Text>().text = "Do + Mi = lightning!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().dofa == true)
            {
                GameObject.Find("DoFa").GetComponent<Text>().text = "Do + Fa = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().doso == true)
            {
                GameObject.Find("DoSo").GetComponent<Text>().text = "Do + So = null...";
            }
            
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
            

            //RE SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().redo == true)
            {
                GameObject.Find("ReDo").GetComponent<Text>().text = "Re + Do = water!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().rere == true)
            {
                GameObject.Find("ReRe").GetComponent<Text>().text = "Re + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().remi == true)
            {
                GameObject.Find("ReMi").GetComponent<Text>().text = "Re + Mi = ice!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().refa == true)
            {
                GameObject.Find("ReFa").GetComponent<Text>().text = "Re + Fa = snow!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().reso == true)
            {
                GameObject.Find("ReSo").GetComponent<Text>().text = "Re + So = null...";
            }
            
             

            //Mi SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mido == true)
            {
                GameObject.Find("MiDo").GetComponent<Text>().text = "Mi + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mire == true)
            {
                GameObject.Find("MiRe").GetComponent<Text>().text = "Mi + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mimi == true)
            {
                GameObject.Find("MiMi").GetComponent<Text>().text = "Mi + Mi = rock!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mifa == true)
            {
                GameObject.Find("MiFa").GetComponent<Text>().text = "Mi + Fa = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().miso == true)
            {
                GameObject.Find("MiSo").GetComponent<Text>().text = "Mi + So = turtle...?";
            }
        
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
            

            //RE SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().redo == true)
            {
                GameObject.Find("ReDo").GetComponent<Text>().text = "Re + Do = water!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().rere == true)
            {
                GameObject.Find("ReRe").GetComponent<Text>().text = "Re + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().remi == true)
            {
                GameObject.Find("ReMi").GetComponent<Text>().text = "Re + Mi = ice!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().refa == true)
            {
                GameObject.Find("ReFa").GetComponent<Text>().text = "Re + Fa = snow!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().reso == true)
            {
                GameObject.Find("ReSo").GetComponent<Text>().text = "Re + So = null...";
            }
            
             
        
            //Mi SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mido == true)
            {
                GameObject.Find("MiDo").GetComponent<Text>().text = "Mi + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mire == true)
            {
                GameObject.Find("MiRe").GetComponent<Text>().text = "Mi + Re = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mimi == true)
            {
                GameObject.Find("MiMi").GetComponent<Text>().text = "Mi + Mi = rock!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().mifa == true)
            {
                GameObject.Find("MiFa").GetComponent<Text>().text = "Mi + Fa = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().miso == true)
            {
                GameObject.Find("MiSo").GetComponent<Text>().text = "Mi + So = turtle...?";
            }

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
            
                //FA SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fado == true)
            {
                GameObject.Find("FaDo").GetComponent<Text>().text = "Fa + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fare == true)
            {
                GameObject.Find("FaRe").GetComponent<Text>().text = "Fa + Re = log!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fami == true)
            {
                GameObject.Find("FaMi").GetComponent<Text>().text = "Fa + Mi = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fafa == true)
            {
                GameObject.Find("FaFa").GetComponent<Text>().text = "Fa + Fa = fruit!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().faso == true)
            {
                GameObject.Find("FaSo").GetComponent<Text>().text = "Fa + So = flower!";
            }

            //SO SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sodo == true)
            {
                GameObject.Find("SoDo").GetComponent<Text>().text = "So + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sore == true)
            {
                GameObject.Find("SoRe").GetComponent<Text>().text = "So + Re = snake!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().somi == true)
            {
                GameObject.Find("SoMi").GetComponent<Text>().text = "So + Mi = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sofa == true)
            {
                GameObject.Find("SoFa").GetComponent<Text>().text = "So + Fa = bread?";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().soso == true)
            {
                GameObject.Find("SoSo").GetComponent<Text>().text = "So + So = critter";
            }
            
        }
        else if (pagethreeStatus == true)
        {
            //Do nothing; can't move forward from here
                //FA SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fado == true)
            {
                GameObject.Find("FaDo").GetComponent<Text>().text = "Fa + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fare == true)
            {
                GameObject.Find("FaRe").GetComponent<Text>().text = "Fa + Re = log!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fami == true)
            {
                GameObject.Find("FaMi").GetComponent<Text>().text = "Fa + Mi = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().fafa == true)
            {
                GameObject.Find("FaFa").GetComponent<Text>().text = "Fa + Fa = fruit!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().faso == true)
            {
                GameObject.Find("FaSo").GetComponent<Text>().text = "Fa + So = flower!";
            }

            //SO SPELLS

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sodo == true)
            {
                GameObject.Find("SoDo").GetComponent<Text>().text = "So + Do = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sore == true)
            {
                GameObject.Find("SoRe").GetComponent<Text>().text = "So + Re = snake!";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().somi == true)
            {
                GameObject.Find("SoMi").GetComponent<Text>().text = "So + Mi = null...";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().sofa == true)
            {
                GameObject.Find("SoFa").GetComponent<Text>().text = "So + Fa = bread?";
            }

            if (GameObject.Find("SpellsDone").GetComponent<DoneSpell>().soso == true)
            {
                GameObject.Find("SoSo").GetComponent<Text>().text = "So + So = critter";
            }
        }
        
    }
    
}
