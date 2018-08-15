using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBoxes : MonoBehaviour {

    public GameObject box1;         //Reference to a tutorial box in the UI
    public bool box1done = false;

    public GameObject box2;         //Reference to a tutorial box in the UI
    public bool box2done = false;

    public GameObject box4;         //Reference to a tutorial box in the UI
    public TutorialTrigger2 trig4;  //Reference to a tutorial trigger script
    public bool box4done = false;   //Bool for box completion

    public GameObject box6;         //Reference to a tutorial box in the UI
    public TutorialTrigger2 trig6;  //Reference to a tutorial trigger script
    public bool box6done = false;   //Bool for box completion

    public GameObject box7;         //Reference to a tutorial box in the UI
    public TutorialTrigger2 trig7;  //Reference to a tutorial trigger script
    public bool box7done = false;   //Bool for box completion

    public GameObject box8;         //Reference to a tutorial box in the UI
    public TutorialTrigger4 trig8;  //Reference to a tutorial trigger script
    public bool box8done = false;   //Bool for box completion

    public GameObject box9;         //Reference to a tutorial box in the UI
    public bool box9done;           //Bool for box completion

    public GameObject player;       //The players game object
    public GameObject tutPoint;     //The tutorial spawn point
    public ImageFade screenFade;    //Reference to the screen fade script
    public DeathLog deathLog;       //Reference to the death log script
    public PlayerStats playerStats; //Reference to the player stats

    public GameObject box10;         //Reference to a tutorial box in the UI
    public bool box10open = false;   //Bool for box 10 being open
    public bool box10closed = false; //Bool for box 10 being closed

    public TutorialTrigger2 trig5;  //Reference to a tutorial trigger script
    public bool box6active;         //Bool for box 6 being active
    public bool box9active;         //Bool for box 9 being active

    public GameObject block1;       //Fencing for the tutorial
    public GameObject block2;       //Fencing for the tutorial
    public GameObject block3;       //Fencing for the tutorial
                                    
    public GameObject trig41;       //Tutorial trigger plate
    public GameObject trig51;       //Tutorial trigger plate
    public GameObject trig61;       //Tutorial trigger plate
    public GameObject trig71;       //Tutorial trigger plate
    public GameObject trig81;       //Tutorial trigger plate


    //Main update method//
    void Update ()
    {
        //If Q is pressed and box 1 is not done, show box 3 and set boolean
        if (Input.GetKeyDown(KeyCode.Q) && box1done == false)
        {
            box1.SetActive(false);
            box2.SetActive(true);
            box1done = true;
        }

        //If Q is pressed and box 1 is done but box 2 is not down, close the boxes and set bool
        if (Input.GetKeyDown(KeyCode.Escape) && box1done == true && box2done == false)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box2done = true;
        }

        //If Q is pressed, and the relevant bools are correct - close the UI boxes and set bool
        if(Input.GetKey(KeyCode.Q) && box2done == true && trig4.entered == true && box4done == false)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box4done = true;
        }

        //If the relevant bools are correct, show box 6
        if (trig5.entered == true && box6done == false && box4done == true)
        {
            box6active = true;
        }

        //If Esc is pressed and the relevant bools are correct - close the UI boxes and set bool
        if (Input.GetKeyDown(KeyCode.Escape) && box4done == true && trig6.entered == true && box6done == false)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box6.SetActive(false);

            box6active = false;

            box6done = true;
        }

        //If Q is pressed and the relevant bools are correct - close the UI boxes and set bool
        if (Input.GetKeyDown(KeyCode.Q) && box6done == true && trig7.entered == true && box7done == false)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box6.SetActive(false);
            box7.SetActive(false);
            box7done = true;
        }

        //If Q is pressed and the relevant bools are correct - close the UI boxes and show box 8
        if (Input.GetKeyDown(KeyCode.Q) && box7done == true && trig8.entered == true && box8done == false)
        {
            //Update the boxes
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box6.SetActive(false);
            box7.SetActive(false);
            box8.SetActive(false);
            box9.SetActive(true);

            //Move the player to the tutorial spawn point with a screen fade
            player.transform.position = tutPoint.transform.position;
            screenFade.OnButtonClick();

            //Remove the tutorial fences
            block1.SetActive(false);
            block2.SetActive(false);
            block3.SetActive(false);

            //Set the bools
            box9active = true;
            box8done = true; 
        }

        //If Esc is pressed and the relevant bools are correct - close the UI boxes and set the bool
        if (Input.GetKeyDown(KeyCode.Escape) && box8done == true && box9done == false)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box6.SetActive(false);
            box7.SetActive(false);
            box8.SetActive(false);
            box9.SetActive(false);

            box9active = false;
            box9done = true;
        }

        //If the boars are dead, and the bools are correct - add XP, show the last box and set bool
        if(deathLog.boar2dead == true && deathLog.boar1dead == true && box10open == false && box9done == true)
        {
            playerStats.AddXP(60);

            box10.SetActive(true);
            box10open = true;
        }

        //If Esc is pressed, and the bools are correct - close the UI boxes and destroy the tutorial components
        if(Input.GetKey(KeyCode.Escape) && box10open == true && box10closed == false)
        {
            //Remove the UI boxes
            box1.SetActive(false);
            box2.SetActive(false);
            box4.SetActive(false);
            box6.SetActive(false);
            box7.SetActive(false);
            box8.SetActive(false);
            box9.SetActive(false);
            box10.SetActive(false);

            //Destroy the tutorial components
            Destroy(trig41);
            Destroy(trig51);
            Destroy(trig61);
            Destroy(trig71);
            Destroy(trig81);

            //Set the boolean
            box10closed = true;

        }
    }
}
