using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QlPage : MonoBehaviour {

    public GameObject page1;            //The first page ob quests
    public bool page1active = true;     //Bool for the active page

    public GameObject page2;            //The second page of quests
    public bool page2active = false;    //Bool for the active page

    public GameObject page3;            //The third page of quests
    public bool page3active = false;    //Bool for the active page

    public AudioSource clickSound;      //Reference to the click sound

    public GameObject slider1;          //Reference to the slider
    public GameObject slider2;          //Reference to the slider
    public GameObject slider3;          //Reference to the slider


    //This method is called when the page needs to move forward//
    public void MovePageForwards()
    {
        //If it is on page 1, set to page 2
        if (page1active == true && page2active == false && page3active == false)
        {
            //Set the page to the correct one
            page1.SetActive(false);
            page1active = false;
            page2.SetActive(true);
            page2active = true;
            page3.SetActive(false);
            page3active = false;

            //Set the slider on the side to the correct one
            slider1.SetActive(false);
            slider2.SetActive(true);
            slider3.SetActive(false);

            clickSound.Play();
        }
        //If it is on page 2, set the page 3
        else if (page1active == false && page2active == true && page3active == false)
        {
            //Set the page to the correct one
            page1.SetActive(false);
            page1active = false;
            page2.SetActive(false);
            page2active = false;
            page3.SetActive(true);
            page3active = true;

            //Set the slider on the side to the correct one
            slider1.SetActive(false);
            slider2.SetActive(false);
            slider3.SetActive(true);

            clickSound.Play();
        }
        //If it is on page 3, do nothing
        else if (page1active == false && page2active == false && page3active == true)
        {
            clickSound.Play();
        }
    }


    //This method is called when the page needs to move backwards//
    public void MovePageBackwards()
    {
        //If it is on page 3, set to page 2
        if (page1active == false && page2active == false && page3active == true)
        {
            //Set the page to the correct one
            page1.SetActive(false);
            page1active = false;
            page2.SetActive(true);
            page2active = true;
            page3.SetActive(false);
            page3active = false;

            //Set the slider on the side to the correct one
            slider1.SetActive(false);
            slider2.SetActive(true);
            slider3.SetActive(false);

            clickSound.Play();
        }
        //if it is on page 2, set to page 1
        else if (page1active == false && page2active == true && page3active == false)
        {
            //Set the page to the correct one
            page1.SetActive(true);
            page1active = true;
            page2.SetActive(false);
            page2active = false;
            page3.SetActive(false);
            page3active = false;

            //Set the slider on the side to the correct one
            slider1.SetActive(true);
            slider2.SetActive(false);
            slider3.SetActive(false);

            clickSound.Play();
        }
        //If it is on page 1, do nothing
        else if (page1active == true && page2active == false && page3active == false)
        {
            clickSound.Play();
        }
    }
}


