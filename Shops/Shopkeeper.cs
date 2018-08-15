using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeeper : MonoBehaviour {

    bool inRange = false;                   //Bool for player range

    public GameObject shopMenu;             //The shops UI menu
    public GameObject shopMenuLink;         //Link the shop script
    public GameObject playerMenu;           //The players UI menu

    ShopMenu shopMenuScript;                //Reference to the shop UI script
    public bool shopMenuActive = false;     //Bool for shop menu active state

    public GameObject notif;                //The shop notification
    public GameObject mainHub;              //Reference to the maninhub on the UI
    public GameObject crosshair;            //Reference to the crosshair on the UI

    public ShopMenu otherShop1;             //Reference to the other shop scripts
    public ShopMenu otherShop2;             //Reference to the other shop scripts
    public ShopMenu otherShop3;             //Reference to the other shop scripts


    //Initialises the reference to the shop menu script//
    void Start()
    {
        shopMenuScript = shopMenuLink.GetComponent<ShopMenu>();
    }


    //Main update method//
    void Update()
    {
        //If the player is in range and Q is pressed
        if (inRange == true && Input.GetKeyDown(KeyCode.Q))
        {
            //Show the UI menus and pause time
            shopMenu.SetActive(true);
            playerMenu.SetActive(true);
            Time.timeScale = 0f;

            //Set the boolean
            shopMenuActive = true;

            //Hide the main hub and the crosshair
            mainHub.SetActive(false);
            crosshair.SetActive(false);
        }

    }


    //If the player is in range, set boolean and show notification//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            notif.SetActive(true);
        }
    }


    //If the player is out of range, set boolean and hide the notification//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            notif.SetActive(false);
        }
    }


    //This method is called to close the shop menu//
    public void CloseMenu()
    {
        //Resume time
        Time.timeScale = 1f;

        //Set all transaction totals to 0
        shopMenuScript.transactionTotal = 0;
        otherShop1.transactionTotal = 0;
        otherShop2.transactionTotal = 0;
        otherShop3.transactionTotal = 0;

        //Reset the UI and booleans
        shopMenu.SetActive(false);
        playerMenu.SetActive(false);
        shopMenuActive = false;
        mainHub.SetActive(true);
        crosshair.SetActive(true);
    }
}
