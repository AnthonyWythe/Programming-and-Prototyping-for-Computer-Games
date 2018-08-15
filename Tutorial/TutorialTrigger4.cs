using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger4 : MonoBehaviour {


    public GameObject tutBox;       //The tutorial UI box
    public bool entered = false;    //Boolean for whether its been triggered

    public GameObject player;       //The player game object
    playerController playerScript;  //Reference to the player script


    //Set up the player script reference//
    void Start()
    {
        playerScript = player.GetComponent<playerController>();
    }


    //If the player is in range, show the UI box and set the boolean//
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && entered == false && playerScript.Count >=5)
        {
            tutBox.SetActive(true);
            entered = true;
        }
    }
}
