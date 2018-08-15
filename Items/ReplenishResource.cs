using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplenishResource : MonoBehaviour {

    public GameObject model;    //The gameobject the holds the item
    Item script;                //The item script
    bool fixer = false;         //Boolean to stop repeating update


    //Sets up the reference to the item script//
    void Start()
    {
        script = model.GetComponent<Item>();
    }


    //If the item has been colelcted, call the growth coroutine//
    void Update()
    {
        //Check that the item has been collected//
        if (script.IsActive == false && fixer == false)
        {
            StartCoroutine(DelayGrowth());
        }
    }


    //Couroutine for regrwoth of the item//
    IEnumerator DelayGrowth()
    {
        //Boolean to stop update method repeating
        fixer = true;

        //Wait for 15 minutes
        yield return new WaitForSeconds(900);

        //Set the item game object as active
        model.SetActive(true);

        //Set the item script as active
        script.IsActive = true;

        //Boolean to stop the update method repeating
        fixer = false;
    }
}
