using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelTutorial : MonoBehaviour {


    public TutorialBoxes tutBoxes;      //Reference to the tutorial script

    public GameObject box3;             //Reference to the third tutorial box

    public GameObject block1;           //Fence for the tutorial
    public GameObject block2;           //Fence for the tutorial
    public GameObject block3;           //Fence for the tutorial

    public GameObject trig4;            //Tutorial trigger game object
    public GameObject trig5;            //Tutorial trigger game object
    public GameObject trig6;            //Tutorial trigger game object
    public GameObject trig7;            //Tutorial trigger game object
    public GameObject trig8;            //Tutorial trigger game object


    //If the player is in range, and the tutorial was not started - delete the tutorial items to cancel it
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && tutBoxes.box4done == false)
        {
            //Remove the tutorial box
            box3.SetActive(false);

            //Remove the tutorial fence
            block1.SetActive(false);
            block2.SetActive(false);
            block3.SetActive(false);

            //Destroy all the tutorial triggers
            Destroy(trig4);
            Destroy(trig5);
            Destroy(trig6);
            Destroy(trig7);
            Destroy(trig8);

        }
    }

}
