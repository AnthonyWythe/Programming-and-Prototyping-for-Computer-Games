using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float damage;                //The amount of attack damage the weapon does
    public bool equipped;               //Whether the weapon is equipped or not

    public Item matchingItem;           //Reference to the weapons item object
    
    public Animation attackAnim;        //Attack animation for the weapon             
    public AudioSource attackSound;     //Attack sound for the weapon

    public MenuControl menuScript;      //Reference to the menu controller

    //This method is called by the player when they want to attack//
    public void Attack()
    {
        //Make sure the menus aren all closed
        if (menuScript.mainMenuActive == false && menuScript.characterMenuActive == false && menuScript.questLogActive == false && menuScript.shopKeeper1.shopMenuActive == false && menuScript.shopKeeper2.shopMenuActive == false
             && menuScript.shopKeeper3.shopMenuActive == false && menuScript.shopKeeper4.shopMenuActive == false)
        {
            //Plays the attack animation and sound
            attackAnim.Play();
            attackSound.Play();
        }
    }
}
