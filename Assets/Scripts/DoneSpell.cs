using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoneSpell : MonoBehaviour
{

//THIS IS PROBABLY A VERY CONVOLUTED METHOD OF REMEMBERING THE SPELLS
    //DO SPELLS
    public bool dodo;
    public bool dore;
    public bool domi;
    public bool dofa;
    public bool doso;
    
    //RE SPELLS
    public bool redo;
    public bool rere;
    public bool remi;
    public bool refa;
    public bool reso;
    
    //MI SPELLS
    public bool mido;
    public bool mire;
    public bool mimi;
    public bool mifa;
    public bool miso;
    
    //FA SPELLS
    public bool fado;
    public bool fare;
    public bool fami;
    public bool fafa;
    public bool faso;


    //SO SPELLS
    public bool sodo;
    public bool sore;
    public bool somi;
    public bool sofa;
    public bool soso;

    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(this.gameObject);
        
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(this.gameObject);
        }
    
        //DO SPELLS
        dodo = false;
        dore = false;
        domi = false;
        dofa = false;
        doso = false;
    
        //RE SPELLS
        redo = false;
        rere = false;
        remi = false;
        refa = false;
        reso = false;
    
        //MI SPELLS
        mido = false;
        mire = false;
        mimi = false;
        mifa = false;
        miso = false;
    
        //FA SPELLS
        fado = false;
        fare = false;
        fami = false;
        fafa = false;
        faso = false;


        //SO SPELLS
        sodo = false;
        sore = false;
        somi = false;
        sofa = false;
        soso = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
