using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegrowPlant : MonoBehaviour {

    public GameObject model;    //The gameobject the holds the item
    Item script;                //The item script
    bool fixer = false;         //Boolean to stop repeating update


    //Sets up the reference to the item script//
    void Start()
    {
        script = model.GetComponent<Item>();
    }

    void Update ()
    {
		if(script.IsActive == false && fixer == false)
        {
            StartCoroutine(DelayGrowth());
        }
	}


    //Couroutine for regrwoth of the item//
    IEnumerator DelayGrowth()
    {
        //Boolean to stop update method repeating
        fixer = true;

        //Wait for 10 minutes
        yield return new WaitForSeconds(600);

        //Set the item game object as active
        model.SetActive(true);

        //Set the item script as active
        script.IsActive = true;

        //Boolean to stop the update method repeating
        fixer = false;
    }
}
