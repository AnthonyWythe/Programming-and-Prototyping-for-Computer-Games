using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IdleDialog : MonoBehaviour {

    public int ID;                      //ID number for the npc
    public string dialogue;             //The dialog of the npc
    public GameObject dialogueBox;      //Reference to the UI object for speech
    public Text dialogueBoxText;        //The text component of the UI object
    bool inRange;                       //Bool for the players distance
    Animation anim;                     //Reference to the animaton component

    //Calls the set dialogue method and initialises the animation reference//
    void Start ()
    {
        SetDialogue();
        anim = GetComponent<Animation>();
	}
	

	//Main update method//
	void Update ()
    {
        //if the player is in range and Q is pressed, show the dialogue box
        if(inRange == true && Input.GetKey(KeyCode.Q))
        {
            dialogueBox.SetActive(true);
            dialogueBoxText.text = dialogue;
        }
    }


    //Check if the player is in range//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }


    //Check if the player is out of range//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            dialogueBox.SetActive(false);
        }
    }


    //Set the correct dialogue depending on ID number//
    public void SetDialogue()
    {
        if(ID == 201)
        {
            dialogue = "Can't stop to chat. It's my turn on patrol duty.";
        }
        else if (ID == 202)
        {
            dialogue = "It's always nice to see a fellow adventurer out in the wilderness! Stay safe on your travels.";
        }
        else if (ID == 203)
        {
            dialogue = "Leave me alone! I'm not to allowed to talk to strangers, and you look very strange.";
        }
        else if (ID == 204)
        {
            dialogue = "Don't you think this is a beautiful place to live? I've been here since I was just a little boy.";
        }
        else if (ID == 205)
        {
            dialogue = "It's my job to guard the market and make sure nobody tries to steal anything.";
        }
    }
}
