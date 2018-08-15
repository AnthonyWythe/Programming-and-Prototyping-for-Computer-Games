using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger3 : MonoBehaviour {

    public GameObject tutBox;       //The tutorial UI box
    public bool entered = false;    //Bool for whether its been triggered

    bool ready = false;             //Is the trigger ready yet


    //If the player is close and trigger is ready, show the UI box and set the bool
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && ready == true)
        {
            tutBox.SetActive(true);
            entered = true;
        }
    }


    //If the player leaves the trigger, set it as ready
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ready = true;
        }
    }
}
