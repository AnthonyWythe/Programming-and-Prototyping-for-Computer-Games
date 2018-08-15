using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

    bool collected = false;         //Has the treasure lid been removed
    public GameObject treasure;     //Reference to the treasure item
    public GameObject treasure2;    //Reference to the second treasure item
    public GameObject notif;        //Notification to open the box
    public AudioSource openSound;   //Sound played when the chest is opened
    public Quest questScript;       //Reference to the appropraite quest
    
    
    //Get and set method for the collected boolean//
    public bool Collected
    {
        get
        {
            return collected;
        }
        set
        {
            collected = value;
        }
    }


    //When the player is in range//
    private void OnTriggerStay(Collider other)
    {
        //If the player is in range and the quest has been started, show the notification
        if (other.gameObject.CompareTag("Player") && questScript.questStarted == true)
        {
            notif.SetActive(true);
        }

        //If the player is in range, the quest has been started and Q is pressed
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.Q) && questScript.questStarted == true)
        {
            //Set as collected
            collected = true;

            //Show the treasure items
            treasure.SetActive(true);
            treasure2.SetActive(true);

            //Hide the notification
             notif.SetActive(false);

            //Playa the open sound
            openSound.Play();

            //Delete the game object
            this.gameObject.SetActive(false);
        }
    }


    //When the player is out of range, hide the notification//
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            notif.SetActive(false);
        }
    }
}
