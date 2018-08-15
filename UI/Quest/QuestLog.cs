using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestLog : MonoBehaviour {

    public GameObject NPC;                  //The NPC game object
    public Quest questScript;               //The quest script

    public GameObject NPCMarker;            //The NPC location marker on the map
    public MarkerRefresh markerRefresh;     //Reference to the refresh marker script

    public GameObject graphic1;             //Quest state graphic
    public GameObject graphic2;             //Quest state graphic
    public GameObject graphic3;             //Quest state graphic

    public Text questName;                  //Text component in the UI
    public Text questTitle;                 //Text component in the UI
    public Text questChar;                  //Text component in the UI
    public Text questProgress;              //Text component in the UI
    public Text questDetails;               //Text component in the UI

    public AudioSource loadSound;           //The loading sound for a quest

    public GameObject objText1;             //Objective text object
    Text text1;                             //Objective text component                
    public GameObject objText2;             //Objective text object
    Text text2;                             //Objective text component
    public GameObject objText3;             //Objective text object
    Text text3;                             //Objective text component
    public GameObject objText4;             //Objective text object
    Text text4;                             //Objective text component
    public GameObject objText5;             //Objective text object
    Text text5;                             //Objective text component

    public GameObject objTick1;             //Objective tick object in the UI
    public GameObject objTick2;             //Objective tick object in the UI
    public GameObject objTick3;             //Objective tick object in the UI
    public GameObject objTick4;             //Objective tick object in the UI
    public GameObject objTick5;             //Objective tick object in the UI

    public GameObject objNo1;               //Objective blank dash in the UI
    public GameObject objNo2;               //Objective blank dash in the UI
    public GameObject objNo3;               //Objective blank dash in the UI
    public GameObject objNo4;               //Objective blank dash in the UI
    public GameObject objNo5;               //Objective blank dash in the UI

    public GameObject objectiveCircle;      //Objective circle in the UI

    public GameObject player;               //Player main game object
    Inventory playerInventory;              //Reference to the player inventory script
    DeathLog deathLog;                      //Reference to the player death log
    playerController playerScript;          //Reference to the player script
    MenuControl menuControl;                //Reference to the player menu control


    //This method is called at the start//
    public void Start ()
    {
        //Set up the reference to the quest script
        questScript = NPC.GetComponent<Quest>();

        //Set up the text component
        text1 = objText1.GetComponent<Text>();
        text2 = objText2.GetComponent<Text>();
        text3 = objText3.GetComponent<Text>();
        text4 = objText4.GetComponent<Text>();
        text5 = objText5.GetComponent<Text>();

        //Set up the player script references
        playerInventory = player.GetComponent<Inventory>();
        playerScript = player.GetComponent<playerController>();
        deathLog = player.GetComponent<DeathLog>();
        menuControl = player.GetComponent<MenuControl>();
    }


    //This method updates the quest log data//
    public void Update()
    {
        //If the quest has not been found, set as undiscovered
        if(questScript.questStarted == false && questScript.finished == false)
        {
            questName.text = "Undiscovered";
            UpdateQuestProgress();
        }
        //If the quest is active, set the log
        else if(questScript.questStarted == true && questScript.finished == false)
        {
            ShowQuest();
            UpdateQuestProgress();
        }
        //If the quest has been finished, grey out the title and set the log
        else if (questScript.questStarted == true && questScript.finished == true)
        {
            ShowQuest();
            questName.color = Color.grey;
            UpdateQuestProgress();
        }
    }


    //This method shows the title of the quest in the log//
    public void ShowQuest()
    {
        questName.text = questScript.Title;
    }


    //This method updates the progress of the quest in the log, by updating its quest state graphic//
    public void UpdateQuestProgress()
    {
        if (questScript.questStarted == false && questScript.finished == false)
        {
            graphic1.SetActive(true);
            graphic2.SetActive(false);
            graphic3.SetActive(false);
        }
        else if (questScript.questStarted == true && questScript.finished == false)
        {
            graphic1.SetActive(false);
            graphic2.SetActive(true);
            graphic3.SetActive(false);
        }
        else if(questScript.questStarted == true && questScript.finished == true)
        {
            graphic1.SetActive(false);
            graphic2.SetActive(false);
            graphic3.SetActive(true);
        }
    }


    //This method updates the active quest details in the log//
    public void ShowQuestDetails()
    {
        //If the quest is undiscovered
        if (questScript.questStarted == false && questScript.finished == false)
        {
            //Show the quest details in the UI
            questTitle.text = "Undiscovered";
            questChar.text = questScript.Person;
            questProgress.text = "Not Started";
            questProgress.color = Color.red;
            questDetails.text = "This quest has yet to be discovered, but the location of the NPC is plotted on the map below.";

            //Update the markers, objective and active quest
            markerRefresh.ClearMarkers();
            NPCMarker.SetActive(true);
            UpdateObjectives(0);
            menuControl.activeQuest = this;

            //Remove the obejctive circle if one is shown, and set it to this one
            if (menuControl.activeObjCircle)
            {
                menuControl.activeObjCircle.SetActive(false);
            }
            menuControl.activeObjCircle = objectiveCircle;

            //Play the load sound
            loadSound.Play();
        }
        else if (questScript.questStarted == true && questScript.finished == false)
        {
            //Show the quest details in the UI
            questTitle.text = questScript.Title;
            questChar.text = questScript.Person;
            questProgress.text = "In Progress";
            questProgress.color = Color.yellow;
            questDetails.text = questScript.LogEntry;

            //Update the markers, objective and active quest
            UpdateObjectives(questScript.ID);
            markerRefresh.ClearMarkers();
            NPCMarker.SetActive(true);
            menuControl.activeQuest = this;

            //Remove the obejctive circle if one is shown, and set it to this one
            if (menuControl.activeObjCircle)
            {
                menuControl.activeObjCircle.SetActive(false);
            }
            objectiveCircle.SetActive(true);
            menuControl.activeObjCircle = objectiveCircle;

            //Play the load sound
            loadSound.Play();
        }
        else if(questScript.questStarted == true && questScript.finished == true)
        {
            //Show the quest details in the UI
            questTitle.text = questScript.Title;
            questChar.text = questScript.Person;
            questProgress.text = "Completed";
            questProgress.color = Color.green;
            questDetails.text = questScript.LogEntry;

            //Update the markers, objective and active quest
            UpdateObjectives(questScript.ID);
            markerRefresh.ClearMarkers();
            NPCMarker.SetActive(true);
            menuControl.activeQuest = this;

            //Remove the obejctive circle if one is shown, and set it to this one
            if (menuControl.activeObjCircle)
            {
                menuControl.activeObjCircle.SetActive(false);
            }
            objectiveCircle.SetActive(true);
            menuControl.activeObjCircle = objectiveCircle;

            //Play the load sound
            loadSound.Play();
        }
    }


    //This method refreshes the objectives//
    public void RefreshObjectives()
    {
        UpdateObjectives(questScript.ID);
    }


    //This method updates the objectives of the current quest, depending on ID//
    public void UpdateObjectives(int ID)
    {
        //Set the text of the objectives
        text1.text = questScript.objText1;
        text2.text = questScript.objText2;
        text3.text = questScript.objText3;
        text4.text = questScript.objText4;
        text5.text = questScript.objText5;

        //Clear the ticks
        objTick1.SetActive(false);
        objTick2.SetActive(false);
        objTick3.SetActive(false);
        objTick4.SetActive(false);
        objTick5.SetActive(false);

        //Set the dashes
        objNo1.SetActive(true);
        objNo2.SetActive(true);
        objNo3.SetActive(true);
        objNo4.SetActive(true);
        objNo5.SetActive(true);

        //if an ID of 0 is given, set all objectives to off (undiscovered quests)
        if(ID == 0)
        {
            objTick1.SetActive(false);
            objTick2.SetActive(false);
            objTick3.SetActive(false);
            objTick4.SetActive(false);
            objTick5.SetActive(false);
            objNo1.SetActive(false);
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);
            text1.text = "";
            text2.text = "";
            text3.text = "";
            text4.text = "";
            text5.text = "";
        }


        //Check the objective progress using ID, and update the graphics//
        //Quest 1
        if (ID == 1)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool axe = false;
            playerInventory.CheckForItem(101);
            axe = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (axe == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 2
        else if (ID == 2)
        {
            //Turn any unused objective graphics off
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool boarP = false;
            playerInventory.CheckForItem(103);
            boarP = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (boarP == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool wolfP = false;
            playerInventory.CheckForItem(112);
            wolfP = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (wolfP == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 3
        else if (ID == 3)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool head = false;
            playerInventory.CheckForItem(109);
            head = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (head == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 4
        else if (ID == 4)
        {
            //Turn any unused objective graphics off
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check if targets are dead
            bool scorpion1 = deathLog.scorpion1dead;
            bool scorpion2 = deathLog.scorpion2dead;

            //If targets are dead, update objective graphics
            if (scorpion1 == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            if (scorpion2 == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
        }
        //Quest 5
        else if (ID == 5)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check if targets are dead
            bool bear = deathLog.bearDead;

            //If targets are dead, update objective graphics
            if (bear == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
        }
        //Quest 6
        else if (ID == 6)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool monkey = false;
            playerInventory.CheckForItem(107);
            monkey = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (monkey == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 7
        else if (ID == 7)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check if targets are dead
            bool croc = deathLog.crocodileDead;

            //If targets are dead, update objective graphics
            if (croc == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
        }
        //Quest 8
        else if (ID == 8)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool relic = false;
            playerInventory.CheckForItem(111);
            relic = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (relic == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 9
        else if (ID == 9)
        {
            //Turn any unused objective graphics off
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool venom = false;
            playerInventory.CheckForItem(105);
            venom = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (venom == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool mushroom = false;
            playerInventory.CheckForItem(110);
            mushroom = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (mushroom == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool berry = false;
            playerInventory.CheckForItem(120);
            berry = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (berry == true)
            {
                objNo3.SetActive(false);
                objTick3.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 10
        else if (ID == 10)
        {
            //Turn any unused objective graphics off
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool south = false;
            playerInventory.CheckForItem(113);
            south = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (south == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool north = false;
            playerInventory.CheckForItem(114);
            north = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (north == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            playerInventory.OwnedItem = false;

        }
        //Quest 11
        else if (ID == 11)
        {
            //Turn any unused objective graphics off
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool wolfP = false;
            playerInventory.CheckForItem(112);
            wolfP = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (wolfP == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool boar = false;
            playerInventory.CheckForItem(102);
            boar = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (boar == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool pepper = false;
            playerInventory.CheckForItem(104);
            pepper = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (pepper == true)
            {
                objNo3.SetActive(false);
                objTick3.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 12
        else if (ID == 12)
        {
            //Turn any unused objective graphics off
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check if targets are dead
            bool goblin4 = deathLog.goblin4dead;
            bool goblin5 = deathLog.goblin5dead;
            bool goblin6 = deathLog.goblin6dead;

            //If targets are dead, update objective graphics
            if (goblin4 == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            if (goblin5 == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            if (goblin6 == true)
            {
                objNo3.SetActive(false);
                objTick3.SetActive(true);
            }
        }
        //Quest 13
        else if (ID == 13)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool treasure = false;
            playerInventory.CheckForItem(115);
            treasure = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (treasure == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
        //Quest 14
        else if (ID == 14)
        {
            //Check for the item in the inventory
            bool corn = false;
            playerInventory.CheckForItem(116);
            corn = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (corn == true)
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool iron = false;
            playerInventory.CheckForItem(117);
            iron = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (iron == true)
            {
                objNo2.SetActive(false);
                objTick2.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool stone = false;
            playerInventory.CheckForItem(118);
            stone = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (stone == true)
            {
                objNo3.SetActive(false);
                objTick3.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            //Check for the item in the inventory
            bool pepper = false;
            playerInventory.CheckForItem(104);
            pepper = playerInventory.OwnedItem;

            //If owned, update objectives graphics and set bool
            if (pepper == true)
            {
                objNo4.SetActive(false);
                objTick4.SetActive(true);
            }
            playerInventory.OwnedItem = false;

            if(playerScript.Count >= 300)
            {
                objNo5.SetActive(false);
                objTick5.SetActive(true);
            }
        }
        //Quest 15
        else if (ID == 15)
        {
            //Turn any unused objective graphics off
            objNo2.SetActive(false);
            objNo3.SetActive(false);
            objNo4.SetActive(false);
            objNo5.SetActive(false);

            //Check for the item in the inventory
            bool sword = false;
            playerInventory.CheckForItem(306);
            sword = playerInventory.OwnedItem;

            //If owned or equipped, update objectives graphics and set bool
            if (sword == true || playerScript.activeWeapon.matchingItem.title == "Arnars Might" || playerScript.unactiveWeapon.matchingItem.title == "Arnars Might")
            {
                objNo1.SetActive(false);
                objTick1.SetActive(true);
            }
            playerInventory.OwnedItem = false;
        }
    }
    }
