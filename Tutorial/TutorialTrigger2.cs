using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger2 : MonoBehaviour {


    public GameObject tutBox;       //The tutorial UI box
    public bool entered = false;    //Bool for whether its been triggered

    public GameObject oldBox;       //The old tutorial UI box


    //If the player is in range, show the new box, hide the old box and set the bool//
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && entered == false)
        {
            oldBox.SetActive(false);
            tutBox.SetActive(true);
            entered = true;
        }
    }
}
