using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNotif : MonoBehaviour {

    public GameObject questNotif;      //The notification object
    public GameObject NPC;             //The character object
    Quest questScript;                 //Reference to the quest script
    bool completed = false;            //Has the quest been completed yet


    //Called at the start - sets up the quest script reference and hides the '?'//
    public void Start()
    {
        questNotif.GetComponent<TextMesh>().text = "";
        questScript = NPC.GetComponent<Quest>();
    }


    //main update method//
    public void Update()
    {
        //Sets the completed boolean as the quests cript finished boolean//
        completed = questScript.finished;

        //If completed, remove the '?'//
        if(completed == true)
        {
            questNotif.GetComponent<TextMesh>().text = "";
        }
    }


    //When the player is in range, set the notification object//
    public void OnTriggerStay(Collider other)
    {
        //Set as white if the quest has been started
        if (other.gameObject.CompareTag("Player") && completed == false && questScript.questStarted == true && questScript.locked == false)
        {
            questNotif.GetComponent<TextMesh>().text = "?";
            questNotif.GetComponent<TextMesh>().color = Color.white;
        }
        //Set as green if the quest has not been started
        else if (other.gameObject.CompareTag("Player") && completed == false && questScript.locked == false)
        {
            questNotif.GetComponent<TextMesh>().text = "?";
            questNotif.GetComponent<TextMesh>().color = Color.green;
        }
        //Set as red if the quest is locked
        else if (other.gameObject.CompareTag("Player") && completed == false && questScript.locked == true)
        {
            questNotif.GetComponent<TextMesh>().text = "?";
            questNotif.GetComponent<TextMesh>().color = Color.red;
        }
    }


    //When the player is out of range, set the notification object to be blank//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            questNotif.GetComponent<TextMesh>().text = "";
        }
    }
}
