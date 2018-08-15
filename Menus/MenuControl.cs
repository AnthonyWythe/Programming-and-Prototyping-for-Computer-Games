using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour {

    public GameObject mainMenu;                 //The main menu UI object
    public bool mainMenuActive = false;         //Boolean for the main menu

    public GameObject mainHub;                  //The main hub UI object
    public bool mainHubActive = true;           //Boolean for the main hub

    public GameObject characterMenu;            //The character menu UI object
    public bool characterMenuActive = false;    //Boolean for the character menu

    public GameObject equipmentMenu;            //The equipment menu UI object
    public bool equipmentMenuActive = false;    //Boolean for the  equipment menu

    public GameObject inventoryMenu;            //The inventory menu UI object
    public bool inventoryMenuActive = false;    //Boolean for the inventory menu

    public GameObject questLog;                 //The quest log UI object
    public bool questLogActive = false;         //Boolean for the quest log

    public GameObject questDetails;             //The quest details UI object
    public bool questDetailsActive = false;     //Boolean for the quest details

    public AudioSource clickSound;              //Reference to the button click sound

    public GameObject attackHelp;               //Helpbox for the attack stat
    public GameObject defenseHelp;              //Helpbox for the defense stat
    public GameObject enduranceHelp;            //Helpbox for the endurance stat
    public GameObject staminaHelp;              //Helpbox for the stamina stat
    public GameObject speedHelp;                //Helpbox for the speed stat
    public GameObject speechHelp;               //Helpbox for the speech stat

    public QuestLog activeQuest;                //Reference to the active quest shown in quest details
    public GameObject activeObjCircle = null;   //Reference to the active objective circle in the quest details

    public GameObject mapHelp;                  //Helpbox for the map 

    public Shopkeeper shopKeeper1;              //Shopkeeper script and boolean
    bool shop1active;
    public Shopkeeper shopKeeper2;              //Shopkeeper script and boolean
    bool shop2active;
    public Shopkeeper shopKeeper3;              //Shopkeeper script and boolean
    bool shop3active;
    public Shopkeeper shopKeeper4;              //Shopkeeper script and boolean
    bool shop4active;

    public GameObject equipStatsHelp;           //Helpbox for the equipment stats
    public GameObject weaponHelp;               //Helpbox for the equipped weapons
    public GameObject armourHelp;               //Helpbox for the equipped armour

    public GameObject attributesHelp;           //Helpbox for the attributes page

    public GameObject itemHelp;                 //Helpbox for the active item panel
    public GameObject inventoryHelp;            //Helpbox for the inventory

    public GameObject logHelp;                  //Helpbox for the quest log
    public GameObject questHelp;                //Helpbox for the quest details
    public GameObject objHelp;                  //Helpbox for the quest objectives

    public GameObject settingsMenu;             //The settings menu UI object
    public GameObject controlsMenu;             //The controls menu UI object

    public GameObject quitConfirm;              //The confirm quit box UI object


    //Main update method for the class//
    void Update ()
    {
        //If M is pressed, and the main menu is not active, call the load main menu method
        if (Input.GetKeyDown(KeyCode.M) && mainMenuActive == false)
        {
            LoadMainMenu();
        }

        //If the main menu is active, character menus, quest menus or shop menus are active - show the cursor and remove the lock
        if (mainMenuActive == true || characterMenuActive == true || questLogActive == true || shopKeeper1.shopMenuActive == true || shopKeeper2.shopMenuActive == true || shopKeeper3.shopMenuActive == true
            || shopKeeper4.shopMenuActive == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        //Else if the same menus are all unactive - hide the cursor and re lock
        else if (mainMenuActive == false && characterMenuActive == false && questLogActive == false && shopKeeper1.shopMenuActive == false && shopKeeper2.shopMenuActive == false && shopKeeper3.shopMenuActive == false
            && shopKeeper4.shopMenuActive == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        //Controls the close character menu shortcut
        if(characterMenuActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            UnloadCharacterMenu();
        }

        //Controls the close quest menu shortcut
        if (questLogActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            UnloadQuestMenu();
        }
    }


    //Method to load the main menu, pauses time//
    public void LoadMainMenu()
    {
        mainMenu.SetActive(true);
        mainMenuActive = true;
        mainHub.SetActive(false);
        Time.timeScale = 0f;
    }
    //Method to unload the main menu, resumes time//
    public void UnloadMainMenu()
    {
        mainMenu.SetActive(false);
        mainMenuActive = false;
        mainHub.SetActive(true);
        Time.timeScale = 1f;

        clickSound.Play();
    }


    //Method to load the settings//
    public void LoadSettings()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
        clickSound.Play();
    }
    //Method to load the settings//
    public void UnloadSettings()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
        clickSound.Play();
    }


    //Method to load the controls menu//
    public void LoadControls()
    {
        controlsMenu.SetActive(true);
        mainMenu.SetActive(false);
        clickSound.Play();
    }
    //Method to load the settings//
    public void UnloadControls()
    {
        controlsMenu.SetActive(false);
        mainMenu.SetActive(true);
        clickSound.Play();
    }


    //method to load to quit confirm panel//
    public void LoadQuitConfirm()
    {
        quitConfirm.SetActive(true);
        clickSound.Play();
    }
    //method to load to quit confirm panel//
    public void UnloadQuitConfirm()
    {
        quitConfirm.SetActive(false);
        clickSound.Play();
    }


    //Method to load the character menu (and equipment/inventory)//
    public void LoadCharacterMenu()
    {
        mainMenu.SetActive(false);
        mainMenuActive = false;
        characterMenu.SetActive(true);
        characterMenuActive = true;
        equipmentMenu.SetActive(true);
        equipmentMenuActive = true;
        inventoryMenu.SetActive(true);
        inventoryMenuActive = true;

        clickSound.Play();
    }
    //Method to unload the character menu (and equipment/inventory)//
    public void UnloadCharacterMenu()
    {
        characterMenu.SetActive(false);
        characterMenuActive = false;
        equipmentMenu.SetActive(false);
        equipmentMenuActive = false;
        inventoryMenu.SetActive(false);
        inventoryMenuActive = false;
        mainMenu.SetActive(true);
        mainMenuActive = true;

        clickSound.Play();
    }


    //This method loads the quest menu//
    public void LoadQuestMenu()
    {
        mainMenu.SetActive(false);
        mainMenuActive = false;
        questLog.SetActive(true);
        questLogActive = true;
        questDetails.SetActive(true);
        questDetailsActive = true;

        clickSound.Play();
    }
    //This method unloads the quest menu//
    public void UnloadQuestMenu()
    {
        mainMenu.SetActive(true);
        mainMenuActive = true;
        questLog.SetActive(false);
        questLogActive = false;
        questDetails.SetActive(false);
        questDetailsActive = false;

        clickSound.Play();
    }


    //This method quits the game//
    public void Quit()
    {
        clickSound.Play();

        Application.Quit();
    }


    //This method refreshes the objectives//
    public void RefreshObjectives()
    {
        activeQuest.RefreshObjectives();
    }


    //This method loads the 'Attack' help window//
    public void LoadAttackHelp()
    {
        attackHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Attack' help window//
    public void UnloadAttackHelp()
    {
        attackHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the 'Defense' help window//
    public void LoadDefenseHelp()
    {
        defenseHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Defense' help window//
    public void UnloadDefenseHelp()
    {
        defenseHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the 'Endurance' help window//
    public void LoadEnduranceHelp()
    {
        enduranceHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Endurance' help window//
    public void UnloadEnduranceHelp()
    {
        enduranceHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the 'Stamina' help window//
    public void LoadStaminaHelp()
    {
        staminaHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Stamina' help window//
    public void UnloadStaminaHelp()
    {
        staminaHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the 'Speed' help window//
    public void LoadSpeedHelp()
    {
        speedHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Speed' help window//
    public void UnloadSpeedHelp()
    {
        speedHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the 'Speech' help window//
    public void LoadSpeechHelp()
    {
        speechHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the 'Speech' help window//
    public void UnloadSpeechHelp()
    {
        speechHelp.SetActive(false);
        clickSound.Play();
    }

    
    //This method loads the map help window//
    public void LoadMapHelp()
    {
        mapHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the map help window//
    public void UnloadMapHelp()
    {
        mapHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the equipment stats help window//
    public void LoadEquipmentStatsHelp()
    {
        equipStatsHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the equipment stats help window//
    public void UnloadEquipmentStatsHelp()
    {
        equipStatsHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the weapon help window//
    public void LoadWeaponHelp()
    {
        weaponHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the weapon help window//
    public void UnloadWeaponHelp()
    {
        weaponHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the armour help window//
    public void LoadArmourHelp()
    {
        armourHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the armour help window//
    public void UnloadArmourHelp()
    {
        armourHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the attributes help window//
    public void LoadAttributesHelp()
    {
        attributesHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the attributes help window//
    public void UnloadAttributesHelp()
    {
        attributesHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the item help window//
    public void LoadItemHelp()
    {
        itemHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the item help window//
    public void UnloadItemHelp()
    {
        itemHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the inventory help window//
    public void LoadInventoryHelp()
    {
        inventoryHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the inventory help window//
    public void UnloadInventoryHelp()
    {
        inventoryHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the questlog help window//
    public void LoadLogHelp()
    {
        logHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the questlog help window//
    public void UnloadLogHelp()
    {
        logHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the quest help window//
    public void LoadQuestHelp()
    {
        questHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the quest help window//
    public void UnloadQuestHelp()
    {
        questHelp.SetActive(false);
        clickSound.Play();
    }


    //This method loads the objective help window//
    public void LoadObjHelp()
    {
        objHelp.SetActive(true);
        clickSound.Play();
    }
    //This method unloads the objective help window//
    public void UnloadObjHelp()
    {
        objHelp.SetActive(false);
        clickSound.Play();
    }
}
