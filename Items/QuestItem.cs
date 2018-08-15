using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour {

    public GameObject NPC;      //The NPC main gameobject
    Quest questScript;          //The quest script

    public GameObject item;     //The item game object
    Item itemScript;            //The item script

    bool fixer = false;         //Boolean to stop the update method repeating


	//Initialise the references to the quest and item scripts//
	void Start ()
    {
        questScript = NPC.GetComponent<Quest>();
        itemScript = item.GetComponent<Item>();
	}
	

	//Main update method//
	void Update ()
    {
        //If the quest has not been started, hide the item
	    if(questScript.questStarted == false)
        {
            item.SetActive(false);
        }
        //If the quest has been started, show the item
        else if(questScript.questStarted == true && fixer == false)
        {
            ShowItem();
        }
	}


    //This method shows the quest item and starts its script//
    public void ShowItem()
    {
        item.SetActive(true);
        itemScript.IsActive = true;
        fixer = true;
    }
}
