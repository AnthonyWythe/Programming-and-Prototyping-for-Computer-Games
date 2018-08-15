using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetails : MonoBehaviour {

    public GameObject nameUI;               //The UI object for the item name
    Text itemName;                          //Text object for the items name
    public GameObject descriptionUI;        //The UI object for the item details
    Text itemDescription;                   //Text object for the item details
    public GameObject valueUI;              //The UI object for the item value
    Text itemValue;                         //Text object for the items value

    RawImage itemBox;                       //Raw image component of item box

    public GameObject player;               //Reference to the player
    playerController playerScript;          //The player controller script
    Inventory playerInventory;              //The players inventory
    PlayerHealth playerHealth;              //The players health

    Weapon activeWeapon;                    //Reference to the players active weapon
    Weapon unactiveWeapon;                  //Reference to the players uanctive weapon

    public EquippedArmour head;             //The players equpped helmet
    public EquippedArmour body;             //The players equipped body armour
    public EquippedArmour feet;             //The players equipped feet armour

    public GameObject coinBox;              //Reference to the coin box in the inventory
    RawImage coinImage;                     //Stores the coin image

    public AudioSource updateSound;         //The audio played when the details update
    private int num = 0;                    //Stops the audio playing on awake

    public Item activeItem;                 //The active item displayed

    public GameObject discardButton;        //Button object on the UI
    public GameObject equipButton;          //Button object on the UI
    public GameObject useButton;            //Button object on the UI

    public AudioSource eatSound;            //Reference to the eat sound
    public AudioSource drinkSound;          //Reference to the drink sound

    public GameObject axe1;                 //The weapons game object
    public Weapon axeW1;                    //The weapon script
    public GameObject axe1item;             //The weapon item game object
    Item item1;                             //The weapons item script

    public GameObject axe2;                 //The weapons game object
    public Weapon axeW2;                    //The weapon script
    public GameObject axe2item;             //The weapon item game object
    Item item2;                             //The weapons item script

    public GameObject axe3;                 //The weapons game object
    public Weapon axeW3;                    //The weapon script
    public GameObject axe3item;             //The weapon item game object
    Item item3;                             //The weapons item script

    public GameObject sword1;               //The weapons game object
    public Weapon swordW1;                  //The weapon script
    public GameObject sword1item;           //The weapon item game object
    Item item4;                             //The weapons item script                                             

    public GameObject sword2;               //The weapons game object
    public Weapon swordW2;                  //The weapon script
    public GameObject sword2item;           //The weapon item game object
    Item item5;                             //The weapons item script

    public GameObject sword3;               //The weapons game object
    public Weapon swordW3;                  //The weapon script
    public GameObject sword3item;           //The weapon item game object
    Item item6;                             //The weapons item script

    public GameObject club1;                //The weapons game object
    public Weapon clubW1;                   //The weapon script
    public GameObject club1item;            //The weapon item game object
    Item item7;                             //The weapons item script

    public GameObject club2;                //The weapons game object
    public Weapon clubW2;                   //The weapon script
    public GameObject club2item;            //The weapon item game object
    Item item8;                             //The weapons item script

    public GameObject club3;                //The weapons game object
    public Weapon clubW3;                   //The weapon script
    public GameObject club3item;            //The weapon item game object
    Item item9;                             //The weapons item script

    public GameObject spear1;               //The weapons game object
    public Weapon spearW1;                  //The weapon script
    public GameObject spear1item;           //The weapon item game object
    Item item10;                            //The weapons item script

    public GameObject spear2;               //The weapons game object
    public Weapon spearW2;                  //The weapon script
    public GameObject spear2item;           //The weapon item game object
    Item item11;                            //The weapons item script

    public GameObject spear3;               //The weapons game object
    public Weapon spearW3;                  //The weapon script
    public GameObject spear3item;           //The weapon item game object
    Item item12;                            //The weapons item script


    //Initialises the variables//
    void Start () {
        
        //Set up the UI components
        itemName = nameUI.GetComponent<Text>();
        itemDescription = descriptionUI.GetComponent<Text>();
        itemValue = valueUI.GetComponent<Text>();
        itemBox = GetComponent<RawImage>();
        coinImage = coinBox.GetComponent<RawImage>();

        //Set up the player script references
        playerScript = player.GetComponent<playerController>();
        playerInventory = player.GetComponent<Inventory>();
        playerHealth = player.GetComponent<PlayerHealth>();

        //Set up the item script references
        item1 = axe1item.GetComponent<Item>();
        item2 = axe2item.GetComponent<Item>();
        item3 = axe3item.GetComponent<Item>();
        item4 = sword1item.GetComponent<Item>();
        item5 = sword2item.GetComponent<Item>();
        item6 = sword3item.GetComponent<Item>();
        item7 = club1item.GetComponent<Item>();
        item8 = club2item.GetComponent<Item>();
        item9 = club3item.GetComponent<Item>();
        item10 = spear1item.GetComponent<Item>();
        item11 = spear2item.GetComponent<Item>();
        item12 = spear3item.GetComponent<Item>();

        //Update the display to show something
        ShowActiveWeapon();
	}


    //This method uses the active item, with variables depending on ID//
    public void UseActiveItem()
    {
        if (activeItem.ID == 102)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(20);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(102);
        }
        else if (activeItem.ID == 104)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(10);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(104);
        }
        else if (activeItem.ID == 116)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(10);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(116);
        }
        else if (activeItem.ID == 120)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(20);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(120);
        }
        else if (activeItem.ID == 123)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(25);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(123);
        }
        else if (activeItem.ID == 126)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(15);
            eatSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(126);
        }
        else if (activeItem.ID == 127)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(15);
            drinkSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(127);
        }
        else if (activeItem.ID == 128)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(25);
            drinkSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(128);
        }
        else if (activeItem.ID == 129)
        {
            //Add health and play the right sound
            playerHealth.AddHealth(50);
            drinkSound.Play();

            //Update the display and remove the item
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(129);
        }
    }


    //This method uses the active item, depending on ID//
    public void RemoveActiveItem()
    {
        if (activeItem.ID == 101)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(101);
        }
        if (activeItem.ID == 102)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(102);
        }
        else if (activeItem.ID == 103)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(103);
        }
        else if (activeItem.ID == 104)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(104);
        }
        else if(activeItem.ID == 105)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(105);
        }
        else if (activeItem.ID == 106)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(106);
        }
        else if (activeItem.ID == 107)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(107);
        }
        else if (activeItem.ID == 108)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(108);
        }
        else if (activeItem.ID == 109)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(109);
        }
        else if (activeItem.ID == 110)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(110);
        }
        else if (activeItem.ID == 112)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(112);
        }
        else if (activeItem.ID == 113)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(113);
        }
        else if (activeItem.ID == 114)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(114);
        }
        else if (activeItem.ID == 115)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(115);
        }
        else if (activeItem.ID == 116)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(116);
        }
        else if (activeItem.ID == 117)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(117);
        }
        else if (activeItem.ID == 118)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(118);
        }
        else if (activeItem.ID == 119)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(119);
        }
        else if (activeItem.ID == 120)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(120);
        }
        else if (activeItem.ID == 121)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(121);
        }
        else if (activeItem.ID == 122)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(122);
        }
        else if (activeItem.ID == 123)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(123);
        }
        else if (activeItem.ID == 124)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(124);
        }
        else if (activeItem.ID == 125)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(125);
        }
        else if (activeItem.ID == 126)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(126);
        }
        else if (activeItem.ID == 127)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(127);
        }
        else if (activeItem.ID == 128)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(128);
        }
        else if (activeItem.ID == 129)
        {
            ShowUnActiveWeapon();
            playerInventory.RemoveItem(129);
        }
        //WEAPON ITEMS//
        else if(activeItem.ID == 301)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            axe1item.SetActive(true);
            axe1item.transform.position = player.transform.position;
            item1.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(301);
        }
        else if (activeItem.ID == 302)
        {
            //Update the display
            ShowUnActiveWeapon();


            //Drop the weapon item to the players location
            axe2item.SetActive(true);
            axe2item.transform.position = player.transform.position;
            item2.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(302);
        }
        else if (activeItem.ID == 303)
        {
            //Update the display
            ShowUnActiveWeapon();


            //Drop the weapon item to the players location
            axe3item.SetActive(true);
            axe3item.transform.position = player.transform.position;
            item3.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(303);
        }
        else if (activeItem.ID == 304)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            sword1item.SetActive(true);
            sword1item.transform.position = player.transform.position;
            item4.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(304);
        }
        else if (activeItem.ID == 305)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            sword2item.SetActive(true);
            sword2item.transform.position = player.transform.position;
            item5.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(305);
        }
        else if (activeItem.ID == 306)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            sword3item.SetActive(true);
            sword3item.transform.position = player.transform.position;
            item6.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(306);
        }
        else if (activeItem.ID == 307)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            club1item.SetActive(true);
            club1item.transform.position = player.transform.position;
            item7.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(307);
        }
        else if (activeItem.ID == 308)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            club2item.SetActive(true);
            club2item.transform.position = player.transform.position;
            item8.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(308);
        }
        else if (activeItem.ID == 309)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            club3item.SetActive(true);
            club3item.transform.position = player.transform.position;
            item9.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(309);
        }
        else if (activeItem.ID == 310)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            spear1item.SetActive(true);
            spear1item.transform.position = player.transform.position;
            item10.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(310);
        }
        else if (activeItem.ID == 311)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            spear2item.SetActive(true);
            spear2item.transform.position = player.transform.position;
            item11.IsActive = true;

            playerInventory.RemoveItem(311);
        }
        else if (activeItem.ID == 312)
        {
            //Update the display
            ShowUnActiveWeapon();

            //Drop the weapon item to the players location
            spear3item.SetActive(true);
            spear3item.transform.position = player.transform.position;
            item12.IsActive = true;

            //Remove the weapon item from the inventory
            playerInventory.RemoveItem(312);
        }
    }


    //This method updates the inventory butttons displayed, depending on the item ID//
    public void UpdateInventoryButtons()
    {
        if (activeItem.ID == 101)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 102)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 103)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 104)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if(activeItem.ID == 105)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 106)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 107)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 108)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 109)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 110)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 111)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 112)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 113)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 114)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 115)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 116)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 117)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 118)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 119)
        {
            discardButton.SetActive(false);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 120)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 121)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 122)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 123)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 124)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 125)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 126)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 127)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 128)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 129)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(false);
            useButton.SetActive(true);
        }
        else if (activeItem.ID == 301)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 302)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 303)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 304)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 305)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 306)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 307)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 308)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 309)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 310)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 311)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
        else if (activeItem.ID == 312)
        {
            discardButton.SetActive(true);
            equipButton.SetActive(true);
            useButton.SetActive(false);
        }
    }


    //This method equips the weapon shown as the active item//
    public void EquipWeapon()
    {
        if(activeItem.ID == 301)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            axe1.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(axeW1,activeItem.ID);

        }
        else if (activeItem.ID == 302)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            axe2.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(axeW2, activeItem.ID);

        }
        else if (activeItem.ID == 303)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            axe3.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(axeW3, activeItem.ID);

        }
        else if (activeItem.ID == 304)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            sword1.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(swordW1, activeItem.ID);

        }
        else if (activeItem.ID == 305)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            sword2.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(swordW2, activeItem.ID);

        }
        else if (activeItem.ID == 306)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            sword3.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(swordW3, activeItem.ID);

        }
        else if (activeItem.ID == 307)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            club1.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(clubW1, activeItem.ID);

        }
        else if (activeItem.ID == 308)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            club2.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(clubW2, activeItem.ID);

        }
        else if (activeItem.ID == 309)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            club3.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(clubW3, activeItem.ID);
        }
        else if (activeItem.ID == 310)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            spear1.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(spearW1, activeItem.ID);

        }
        else if (activeItem.ID == 311)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            spear2.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(spearW2, activeItem.ID);

        }
        else if (activeItem.ID == 312)
        {
            //Swap the weapon game objects
            playerScript.activeWeapon.gameObject.SetActive(false);
            spear3.SetActive(true);

            //Hide the buttons displayed
            equipButton.SetActive(false);
            discardButton.SetActive(false);

            //Equip the new weapon to the player script
            playerScript.EquipWeapon(spearW3, activeItem.ID);

        }
    }


    //Updates the display to show the equipped armour on the head//
    public void ShowActiveHead()
    {
        itemName.text = head.equippedArmour.title.ToString();
        itemDescription.text = head.equippedArmour.description.ToString();
        itemValue.text = head.equippedArmour.value.ToString();

        itemBox.texture = head.equippedArmour.image;

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);

        updateSound.Play();
    }


    //Updates the display to show the equipped armour on the body//
    public void ShowActiveBody()
    {
        itemName.text = body.equippedArmour.title.ToString();
        itemDescription.text = body.equippedArmour.description.ToString();
        itemValue.text = body.equippedArmour.value.ToString();

        itemBox.texture = body.equippedArmour.image;

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);

        updateSound.Play();
    }


    //Updates the display to show the equipped armour on the feet//
    public void ShowActiveFeet()
    {
        itemName.text = feet.equippedArmour.title.ToString();
        itemDescription.text = feet.equippedArmour.description.ToString();
        itemValue.text = feet.equippedArmour.value.ToString();

        itemBox.texture = feet.equippedArmour.image;

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);

        updateSound.Play();
    }


    //Updates the display to show the players active weapon//
    public void ShowActiveWeapon()
    {
        itemName.text = playerScript.activeWeapon.matchingItem.title.ToString();
        itemDescription.text = playerScript.activeWeapon.matchingItem.description.ToString();
        itemValue.text = playerScript.activeWeapon.matchingItem.value.ToString();

        itemBox.texture = playerScript.activeWeapon.matchingItem.image;

        activeItem = playerScript.activeWeapon.matchingItem;

        if (num > 0)
        {
            updateSound.Play();
        }

        num = num + 1;

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);
    }


    //Updates the display to show the players unactive weapon//
    public void ShowUnActiveWeapon()
    {
        itemName.text = playerScript.unactiveWeapon.matchingItem.title.ToString();
        itemDescription.text = playerScript.unactiveWeapon.matchingItem.description.ToString();
        itemValue.text = playerScript.unactiveWeapon.matchingItem.value.ToString();

        itemBox.texture = playerScript.unactiveWeapon.matchingItem.image;

        activeItem = playerScript.unactiveWeapon.matchingItem;

        updateSound.Play();

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);
    }


    //Updates the display the show the players coin amount//
    public void ShowCoins()
    {
        itemName.text = "Gold";
        itemDescription.text = "Gold is the money of kings; silver is the money of gentlemen; barter is the money of peasants; but debt is the money of slaves.";
        itemValue.text = playerScript.Count.ToString();

        itemBox.texture = coinImage.texture;

        updateSound.Play();

        UpdateInventoryButtons();

        discardButton.SetActive(false);
        equipButton.SetActive(false);
        useButton.SetActive(false);
    }


    //Updates the display to show the highlighted item//
    public void ShowBox1()
    {
        if (playerInventory.Items.Count > 0)
        {
            itemName.text = playerInventory.Items[0].title;
            itemDescription.text = playerInventory.Items[0].description;
            itemValue.text = playerInventory.Items[0].value.ToString();

            itemBox.texture = playerInventory.Items[0].image;

            activeItem = playerInventory.Items[0];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox2()
    {
        if (playerInventory.Items.Count > 1)
        {
            itemName.text = playerInventory.Items[1].title;
            itemDescription.text = playerInventory.Items[1].description;
            itemValue.text = playerInventory.Items[1].value.ToString();

            itemBox.texture = playerInventory.Items[1].image;

            activeItem = playerInventory.Items[1];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox3()
    {
        if (playerInventory.Items.Count > 2)
        {
            itemName.text = playerInventory.Items[2].title;
            itemDescription.text = playerInventory.Items[2].description;
            itemValue.text = playerInventory.Items[2].value.ToString();

            itemBox.texture = playerInventory.Items[2].image;

            activeItem = playerInventory.Items[2];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox4()
    {
        if (playerInventory.Items.Count > 3)
        {
            itemName.text = playerInventory.Items[3].title;
            itemDescription.text = playerInventory.Items[3].description;
            itemValue.text = playerInventory.Items[3].value.ToString();

            itemBox.texture = playerInventory.Items[3].image;

            activeItem = playerInventory.Items[3];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox5()
    {
        if (playerInventory.Items.Count > 4)
        {
            itemName.text = playerInventory.Items[4].title;
            itemDescription.text = playerInventory.Items[4].description;
            itemValue.text = playerInventory.Items[4].value.ToString();

            itemBox.texture = playerInventory.Items[4].image;

            activeItem = playerInventory.Items[4];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox6()
    {
        if (playerInventory.Items.Count > 5)
        {
            itemName.text = playerInventory.Items[5].title;
            itemDescription.text = playerInventory.Items[5].description;
            itemValue.text = playerInventory.Items[5].value.ToString();

            itemBox.texture = playerInventory.Items[5].image;

            activeItem = playerInventory.Items[5];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox7()
    {
        if (playerInventory.Items.Count > 6)
        {
            itemName.text = playerInventory.Items[6].title;
            itemDescription.text = playerInventory.Items[6].description;
            itemValue.text = playerInventory.Items[6].value.ToString();

            itemBox.texture = playerInventory.Items[6].image;

            activeItem = playerInventory.Items[6];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox8()
    {
        if (playerInventory.Items.Count > 7)
        {
            itemName.text = playerInventory.Items[7].title;
            itemDescription.text = playerInventory.Items[7].description;
            itemValue.text = playerInventory.Items[7].value.ToString();

            itemBox.texture = playerInventory.Items[7].image;

            activeItem = playerInventory.Items[7];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox9()
    {
        if (playerInventory.Items.Count > 8)
        {
            itemName.text = playerInventory.Items[8].title;
            itemDescription.text = playerInventory.Items[8].description;
            itemValue.text = playerInventory.Items[8].value.ToString();

            itemBox.texture = playerInventory.Items[8].image;

            activeItem = playerInventory.Items[8];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox10()
    {
        if (playerInventory.Items.Count > 9)
        {
            itemName.text = playerInventory.Items[9].title;
            itemDescription.text = playerInventory.Items[9].description;
            itemValue.text = playerInventory.Items[9].value.ToString();

            itemBox.texture = playerInventory.Items[9].image;

            activeItem = playerInventory.Items[9];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox11()
    {
        if (playerInventory.Items.Count > 10)
        {
            itemName.text = playerInventory.Items[10].title;
            itemDescription.text = playerInventory.Items[10].description;
            itemValue.text = playerInventory.Items[10].value.ToString();

            itemBox.texture = playerInventory.Items[10].image;

            activeItem = playerInventory.Items[10];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox12()
    {
        if (playerInventory.Items.Count > 11)
        {
            itemName.text = playerInventory.Items[11].title;
            itemDescription.text = playerInventory.Items[11].description;
            itemValue.text = playerInventory.Items[11].value.ToString();

            itemBox.texture = playerInventory.Items[11].image;

            activeItem = playerInventory.Items[11];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox13()
    {
        if (playerInventory.Items.Count > 12)
        {
            itemName.text = playerInventory.Items[12].title;
            itemDescription.text = playerInventory.Items[12].description;
            itemValue.text = playerInventory.Items[12].value.ToString();

            itemBox.texture = playerInventory.Items[12].image;

            activeItem = playerInventory.Items[12];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox14()
    {
        if (playerInventory.Items.Count > 13)
        {
            itemName.text = playerInventory.Items[13].title;
            itemDescription.text = playerInventory.Items[13].description;
            itemValue.text = playerInventory.Items[13].value.ToString();

            itemBox.texture = playerInventory.Items[13].image;

            activeItem = playerInventory.Items[13];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox15()
    {
        if (playerInventory.Items.Count > 14)
        {
            itemName.text = playerInventory.Items[14].title;
            itemDescription.text = playerInventory.Items[14].description;
            itemValue.text = playerInventory.Items[14].value.ToString();

            itemBox.texture = playerInventory.Items[14].image;

            activeItem = playerInventory.Items[14];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox16()
    {
        if (playerInventory.Items.Count > 15)
        {
            itemName.text = playerInventory.Items[15].title;
            itemDescription.text = playerInventory.Items[15].description;
            itemValue.text = playerInventory.Items[15].value.ToString();

            itemBox.texture = playerInventory.Items[15].image;

            activeItem = playerInventory.Items[15];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox17()
    {
        if (playerInventory.Items.Count > 16)
        {
            itemName.text = playerInventory.Items[16].title;
            itemDescription.text = playerInventory.Items[16].description;
            itemValue.text = playerInventory.Items[16].value.ToString();

            itemBox.texture = playerInventory.Items[16].image;

            activeItem = playerInventory.Items[16];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox18()
    {
        if (playerInventory.Items.Count > 17)
        {
            itemName.text = playerInventory.Items[17].title;
            itemDescription.text = playerInventory.Items[17].description;
            itemValue.text = playerInventory.Items[17].value.ToString();

            itemBox.texture = playerInventory.Items[17].image;

            activeItem = playerInventory.Items[17];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox19()
    {
        if (playerInventory.Items.Count > 18)
        {
            itemName.text = playerInventory.Items[18].title;
            itemDescription.text = playerInventory.Items[18].description;
            itemValue.text = playerInventory.Items[18].value.ToString();

            itemBox.texture = playerInventory.Items[18].image;

            activeItem = playerInventory.Items[18];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox20()
    {
        if (playerInventory.Items.Count > 19)
        {
            itemName.text = playerInventory.Items[19].title;
            itemDescription.text = playerInventory.Items[19].description;
            itemValue.text = playerInventory.Items[19].value.ToString();

            itemBox.texture = playerInventory.Items[19].image;

            activeItem = playerInventory.Items[19];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox21()
    {
        if (playerInventory.Items.Count > 20)
        {
            itemName.text = playerInventory.Items[20].title;
            itemDescription.text = playerInventory.Items[20].description;
            itemValue.text = playerInventory.Items[20].value.ToString();

            itemBox.texture = playerInventory.Items[20].image;

            activeItem = playerInventory.Items[20];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox22()
    {
        if (playerInventory.Items.Count > 21)
        {
            itemName.text = playerInventory.Items[21].title;
            itemDescription.text = playerInventory.Items[21].description;
            itemValue.text = playerInventory.Items[21].value.ToString();

            itemBox.texture = playerInventory.Items[21].image;

            activeItem = playerInventory.Items[21];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox23()
    {
        if (playerInventory.Items.Count > 22)
        {
            itemName.text = playerInventory.Items[22].title;
            itemDescription.text = playerInventory.Items[22].description;
            itemValue.text = playerInventory.Items[22].value.ToString();

            itemBox.texture = playerInventory.Items[22].image;

            activeItem = playerInventory.Items[22];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox24()
    {
        if (playerInventory.Items.Count > 23)
        {
            itemName.text = playerInventory.Items[23].title;
            itemDescription.text = playerInventory.Items[23].description;
            itemValue.text = playerInventory.Items[23].value.ToString();

            itemBox.texture = playerInventory.Items[23].image;

            activeItem = playerInventory.Items[23];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox25()
    {
        if (playerInventory.Items.Count > 24)
        {
            itemName.text = playerInventory.Items[24].title;
            itemDescription.text = playerInventory.Items[24].description;
            itemValue.text = playerInventory.Items[24].value.ToString();

            itemBox.texture = playerInventory.Items[24].image;

            activeItem = playerInventory.Items[24];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox26()
    {
        if (playerInventory.Items.Count > 25)
        {
            itemName.text = playerInventory.Items[25].title;
            itemDescription.text = playerInventory.Items[25].description;
            itemValue.text = playerInventory.Items[25].value.ToString();

            itemBox.texture = playerInventory.Items[25].image;

            activeItem = playerInventory.Items[25];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }


    //Updates the display to show the highlighted item//
    public void ShowBox27()
    {
        if (playerInventory.Items.Count > 26)
        {
            itemName.text = playerInventory.Items[26].title;
            itemDescription.text = playerInventory.Items[26].description;
            itemValue.text = playerInventory.Items[26].value.ToString();

            itemBox.texture = playerInventory.Items[26].image;

            activeItem = playerInventory.Items[26];

            updateSound.Play();

            UpdateInventoryButtons();
        }
    }
}
