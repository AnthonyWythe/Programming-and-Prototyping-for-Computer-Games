using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBarn : MonoBehaviour {

    public GameObject NPC;      //The NPC game object
    Quest questScript;          //The quest script

    public GameObject oldBarn;  //Old barn game objects
    public GameObject newBarn;  //New barn game objects

	//Set up the reference to the quest script//
	void Start ()
    {
        questScript = NPC.GetComponent<Quest>();
	}

	
	//Main update method//
	void Update ()
    {
        //If the quest is not finished, show the old barn//
		if(questScript.finished == false)
        {
            oldBarn.SetActive(true);
            newBarn.SetActive(false);
        }
        //Else if the quest is finished, show the new barn//
        else if (questScript.finished == true)
        {
            oldBarn.SetActive(false);
            newBarn.SetActive(true);
        }
    }
}
