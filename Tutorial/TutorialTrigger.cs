using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour {


    public GameObject tutBox;       //The tutorial box on the UI
    public bool entered = false;    //Bool for whether its been used


    //If the player is in range, show the UI and set the boolean
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && entered == false)
        {
            tutBox.SetActive(true);
            entered = true;
        }
    }
}
