using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUnlock : MonoBehaviour {

    public GameObject NPC;          //The NPC game object
    Quest questScript;              //The quest script

    public QuestNotif questNotif;   //The quest notification

    public GameObject player;       //The player game object
    PlayerStats playerStats;        //The player stats script

    public GameObject lockedNotif;  //The locked notifcation


    //Sets up the reference to the quest and player stats scripts//
	void Start ()
    {
        questScript = NPC.GetComponent<Quest>();
        playerStats = player.GetComponent<PlayerStats>();
	}


    //If the player is in range and the quest is locked, show the locked notification//
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && questScript.locked == true)
        {
            lockedNotif.SetActive(true);
        }
    }


    //IF the player is out of range, hide the locked notification//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lockedNotif.SetActive(false);
        }
    }


    //Main update method//
    void Update ()
    {
        //If the player is lower than level six, lock the quest
		if(playerStats.level < 6)
        {
            questScript.locked = true;

            questScript.enabled = false;
            questNotif.enabled = false;
        }
        //If the player is higher than level six, unlock the quest
        else if(playerStats.level >=6)
        {
            questScript.enabled = true;
            questNotif.enabled = true;

            questScript.locked = false;
        }
	}
}
