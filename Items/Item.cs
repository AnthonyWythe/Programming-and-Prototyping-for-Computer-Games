using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public float ID;                //The ID of the item
    public bool questItem;          //Bool for whether it is a quest item or not

    public string title;            //The title of the item
    public string description;      //The items decription
    public float value;             //The value of the item
    public Texture image;           //The items image

    bool inRange = false;           //Is the player in range
    bool isActive;                  //Is the item active, with get/set method
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    public GameObject player;       //The players game object
    Inventory playerInventory;      //Reference to the players inventory
    public GameObject notif;        //The notification for the item


	//Initialise the class by updating its details, and setting up the reference to the inventory//
	void Start ()
    {
        UpdateItemDetails();
        playerInventory = player.GetComponent<Inventory>();
	}


    //Main update method//
    public void Update()
    {
        //If the player is in range, E is pressed, the item is active and the inventory is not full; pick the item up
        if (inRange == true && Input.GetKeyDown(KeyCode.E) && isActive == true && playerInventory.fullUp == false)
        {
            PickMeUp();
        }

        //Sets the item to rotate depending on ID
        if(ID == 101 || ID == 103 || ID == 105 || ID == 106 || ID == 107 || ID == 108 || ID == 109 || ID == 112 || ID == 122 || ID == 123 || ID == 124)
        {
            transform.Rotate(Vector3.up * (Time.deltaTime) * 24);
        }
        else if (ID == 102 || ID == 125)
        {
            transform.Rotate(Vector3.right * (Time.deltaTime) * 24);
        }

        //If the player is in range show the notification
        if (inRange == true)
        {
            notif.SetActive(true);
        }
        //If the player is out of range, hide the notification
        else if (inRange == false)
        {
            notif.SetActive(false);
        }
    }


    //Checks if the player is in range//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }


    //Checks if the player out of range//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }


    //This method is called when the item is picked up//
    public void PickMeUp()
    {
        //Add the item to the inventory
        playerInventory.AddItem(this);

        //Set booleans
        isActive = false;
        inRange = false;

        //Hide the item gameobject
        gameObject.SetActive(false);
    }


    //This method reads the ID - then updates the title, deescription and value - then sets the quest item and active bools
    public void UpdateItemDetails()
    {
        if(ID == 101)
        {
            title = "Bills Axe";
            description = "This looks like the lost axe that Bill Woodchuck asked me to find for him.";
            value = 0;

            questItem = true;
            isActive = false;
        }
        else if (ID == 102)
        {
            title = "Boar Meat";
            description = "Fresh red meat from a wild boar. Full of protein when eaten. (+20 health)";
            value = 5;

            questItem = false;
            isActive = true;
        }
        else if (ID == 103)
        {
            title = "Boar Pelt";
            description = "Fur taken from a wild boar. Its thick, leathery texture would be great for crafting.";
            value = 10;

            questItem = false;
            isActive = true;
        }
        else if (ID == 104)
        {
            title = "Pepper";
            description = "A sweet red pepper. It looks ripe, juicy and ready to eat. (+10 health)";
            value = 5;

            questItem = false;
            isActive = true;
        }
        else if(ID == 105)
        {
            title = "Scorpion Venom";
            description = "Poisonous venom harvested from a giant scorpions stinger.";
            value = 10;

            questItem = false;
            isActive = true;
        }
        else if (ID == 106)
        {
            title = "Bear Pelt";
            description = "The fur of a great brown grizzly bear.";
            value = 40;

            questItem = false;
            isActive = true;
        }
        else if (ID == 107)
        {
            title = "Lost Toy";
            description = "This plush monkey toy was lost by a little girl in the town.";
            value = 0;

            questItem = true;
            isActive = false;
        }
        else if (ID == 108)
        {
            title = "Crocodile Skin";
            description = "Skin taken from a killed crocodile. High in value.";
            value = 35;

            questItem = false;
            isActive = true;
        }
        else if (ID == 109)
        {
            title = "Goblin Helm";
            description = "The headpiece of a goblin clan leader. Made from dead animals.";
            value = 50;

            questItem = false;
            isActive = true;
        }
        else if (ID == 110)
        {
            title = "Wild Mushroom";
            description = "Wild funghi from the forests. It looks poisonous.";
            value = 10;

            questItem = false;
            isActive = true;
        }
        else if (ID == 111)
        {
            title = "Ancient Relic";
            description = "This pagan artefact appears to made of solid gold.";
            value = 600;

            questItem = true;
            isActive = true;
        }
        else if (ID == 112)
        {
            title = "Wolf Pelt";
            description = "Pelt taken from a grey wolf in the forests.";
            value = 10;

            questItem = false;
            isActive = true;
        }
        else if (ID == 113)
        {
            title = "South Markings";
            description = "Sketches of the markings on the south runestone.";
            value = 0;

            questItem = true;
            isActive = false;
        }
        else if (ID == 114)
        {
            title = "North Markings";
            description = "Sketches of the markings on the north runestone.";
            value = 0;

            questItem = true;
            isActive = false;
        }
        else if(ID == 115)
        {
            title = "Gold Bars";
            description = "Solid gold bars, stolen and buried by the Xenis brothers.";
            value = 2000;

            questItem = true;
            IsActive = true;
        }
        else if (ID == 116)
        {
            title = "Corn";
            description = "Harvested corn, good for feeding animals, among other things. (+10 Health)";
            value = 5;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 117)
        {
            title = "Iron";
            description = "One of the most essential resources in these lands.";
            value = 25;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 118)
        {
            title = "Stone";
            description = "Stone is an important resource for building.";
            value = 15;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 120)
        {
            title = "Hackleberry";
            description = "Ripe hackleberries. Known to contain a lot of vitamins. (+20 Health)";
            value = 10;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 121)
        {
            title = "Stone Head";
            description = "This is so old, it might be of great value.";
            value = 120;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 122)
        {
            title = "Spider Venom";
            description = "Poisonous venom taken from a giant spiders fangs.";
            value = 10;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 123)
        {
            title = "Raw Fish";
            description = "Orange-Finned Perch, caught from the local rivers or lake. (+25 Health)";
            value = 10;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 124)
        {
            title = "Ruby";
            description = "A precious red stone, should be worth some money.";
            value = 110;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 125)
        {
            title = "Gold Ingot";
            description = "A bar of solid gold. High in value.";
            value = 150;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 126)
        {
            title = "Egg";
            description = "A chickens egg, fresh from your farm. (+15 Health)";
            value = 10;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 127)
        {
            title = "Milk";
            description = "Milk taken from a dairy cow. (+15 Health)";
            value = 10;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 128)
        {
            title = "Potion";
            description = "A regular size health potion. (+25 Health)";
            value = 25;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 129)
        {
            title = "Large Potion";
            description = "A large size health potion. (+50 Health)";
            value = 50;

            questItem = false;
            IsActive = true;
        }
        //WEAPON ITEMS//
        else if(ID == 301)
        {
            title = "Woodcutters Axe";
            description = "A rusty axe for chopping up wood.   (+1 Attack)";
            value = 20;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 302)
        {
            title = "Viking Axe";
            description = "A strong steel axe, made for a Viking soldier.   (+2 Attack)";
            value = 110;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 303)
        {
            title = "The Beheader";
            description = "Once an excecutors axe, famous for decapitation.   (+3 Attack)";
            value = 300;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 304)
        {
            title = "Iron Sword";
            description = "An iron sword; reliable, but not the most dangerous.   (+1 Attack)";
            value = 40;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 305)
        {
            title = "Viking Sword";
            description = "A strong steel sword, made for a Viking soldier.   (+2 Attack)";
            value = 110;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 306)
        {
            title = "Arnars Might";
            description = "This legendary sword belonged to a mighty general.   (+3 Attack)";
            value = 300;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 307)
        {
            title = "Club";
            description = "A wooden club for hitting things with.   (+1 Attack)";
            value = 40;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 308)
        {
            title = "Spiked Mace";
            description = "This mace is designed to do some damage.   (+2 Attack)";
            value = 120;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 309)
        {
            title = "Skull Basher";
            description = "A powerful weapon, does exactly as it says it does.   (+3 Attack)";
            value = 300;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 310)
        {
            title = "Fishing Spear";
            description = "Great for catching fish, not very good for fighting enemies.   (+1 Attack)";
            value = 40;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 311)
        {
            title = "Halberd";
            description = "A halberd pike, standard issue weapon for town guards.   (+2 Attack)";
            value = 140;

            questItem = false;
            IsActive = true;
        }
        else if (ID == 312)
        {
            title = "Naginata";
            description = "The Naginata spears are used by elite Yurimoto warriors.   (+3 Attack)";
            value = 300;

            questItem = false;
            IsActive = true;
        }
    }
}
