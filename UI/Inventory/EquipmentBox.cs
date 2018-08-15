using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentBox : MonoBehaviour {

    public GameObject player;           //Reference to the player
    playerController playerScript;      //Reference to the player controller script
    Texture image;                      //The image to be displayed

    public int number;                  //The grid number of the equipment box 
    public GameObject box;              //Reference to the box on the UI
    RawImage menuBox;                   //The image displayed on the UI
    

    //Initalises the variables//
    void Start ()
    {
        playerScript = player.GetComponent<playerController>();
        menuBox = box.GetComponent<RawImage>();
	}
	

    //Main update method for the box//
	void Update ()
    {
        //Gets the images for the players equipped weapons
        Texture activeWeapon = playerScript.activeWeapon.matchingItem.image;
        Texture unactiveWeapon = playerScript.unactiveWeapon.matchingItem.image;

        //If grid number is 0, show the unactive weapon
        if(number == 0)
        {
            image = unactiveWeapon;
            menuBox.texture = image;
        }

        //If the grid number is 1, show the active weapon
        else if(number == 1)
        {
            image = activeWeapon;
            menuBox.texture = image;
        }
	}
}
