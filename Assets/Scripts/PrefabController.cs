using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    //Prefabs
    public GameObject Fire;

    public GameObject Ice;

    public GameObject Lightning;

    public GameObject Snow;

    public GameObject Water;

    public GameObject Log;

    public GameObject Snake;

    public GameObject Rock;

    public GameObject Flower;

    public GameObject Bread;

    public GameObject Fruit;

    public GameObject Critter;

    GameObject empty;

    public GameObject getPrefab(string effect)
    {
        switch(effect)
        {
            case "Fire":
                return Fire;

            case "Ice":
                return Ice;

            case "Snow":
                return Snow;

            case "Log":
                return Log;
                
            case "Water":
                return Water;
                
            case "Bread":
                return Bread;
                
            case "Critter":
                return Critter;
                
            case "Lightning":
                return Lightning;
                
            case "Snake":
                return Snake;
                
            case "Rock":
                return Rock;
                
            case "Flower":
                return Flower;
                
            case "Fruit":
                return Fruit;
                
            default:
                return empty;
                
        }
           
    }
}
