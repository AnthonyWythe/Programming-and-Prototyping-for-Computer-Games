using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour {

    public int ID;                  //ID number for the menu
    public Texture blankbox;        //Blank inventory image
    public RawImage box1;           //Reference to box in the UI
    public RawImage box2;           //Reference to box in the UI
    public RawImage box3;           //Reference to box in the UI

    public GameObject player;       //The player game object
    playerController playerScript;  //Reference to the player script
    Inventory playerInventory;      //Reference to the player inventory
    PlayerStats playerStats;        //Reference to the player stats
    ArmourControl playerArmour;     //Reference to the player armour

    public GameObject item1;        //Shop item number 1
    Item item1sc;                   //Item script number 1
    public GameObject item2;        //Shop item number 2
    Item item2sc;                   //Item script number 2
    public GameObject item3;        //Shop item number 3
    Item item3sc;                   //Item script number 3
    public GameObject item4;        //Shop item number 4
    Item item4sc;                   //Item script number 4

    public GameObject nameUI;       //Name of the item in the UI
    Text itemName;                  //Name text component
    public GameObject descriptionUI;//Description of the item in the UI
    Text itemDetails;               //Details text component
    public GameObject valueUI;      //Value of the item in the UI
    Text itemValue;                 //Value text component UI
    RawImage itemBox;               //The item image box

    public Item activeItem;         //The currently displayed item

    public AudioSource saleSound;   //Reference to the sale sound

    //Shop 1 booleans
    bool vSword = false;
    bool vAxe = false;
    bool halberd = false;

    //Shop 2 booleans
    bool sMace = false;
    bool sCrusher = false;
    bool naginata = false;

    public float transactionTotal = 0;  //Transaction total variable
    public Text transactionText;        //Text component for transaction total
    public Text totalCoins;             //Text component for player total coins

    //Armour upgrade booleans
    public bool helmet1 = false;
    public bool helmet2 = false;
    public bool helmet3 = false;

    //Armour upgrade booleans
    public bool body1 = false;
    public bool body2 = false;
    public bool body3 = false;

    //Armour upgrade booleans
    public bool feet1 = false;
    public bool feet2 = false;
    public bool feet3 = false;

    //Initialises all of the components//
    public void Start()
    {
        //Set up all of the player scripts
        playerScript = player.GetComponent<playerController>();
        playerInventory = player.GetComponent<Inventory>();
        playerStats = player.GetComponent<PlayerStats>();
        playerArmour = player.GetComponent<ArmourControl>();

        //Set up the item box component
        itemBox = GetComponent<RawImage>();

        //Set up the item script references
        item1sc = item1.GetComponent<Item>();
        item2sc = item2.GetComponent<Item>();
        item3sc = item3.GetComponent<Item>();
        item4sc = item4.GetComponent<Item>();

        //Set up the UI text components
        itemName = nameUI.GetComponent<Text>();
        itemDetails = descriptionUI.GetComponent<Text>();
        itemValue = valueUI.GetComponent<Text>();

        //Display the fourth item
        ShowItem4();

        //If the armour vendor, show the body armour upgrade
        if(ID == 4)
        {
            ShowBodyUpgrade();
        }
    }


    //This updates the transaction box//
    public void Update()
    {
        //Update the transaction total and player gold in the UI
        transactionText.text = transactionTotal.ToString();
        totalCoins.text = playerScript.Count.ToString();

        //If the transaction is a plus, show green
        if(transactionTotal > 0)
        {
            transactionText.color = Color.green;
        }
        //Else if the transaction is a minus, show red
        else if(transactionTotal < 0)
        {
            transactionText.color = Color.red;
        }
        //Else if the transaction is 0, show yellow
        else if(transactionTotal == 0)
        {
            transactionText.color = Color.yellow;
        }
    }


    //This method shows the first item details, depending on ID//
    public void ShowItem1()
    {
        if (ID == 1 && vSword == false)
        {
            activeItem = item1sc;

            itemName.text = "Viking Sword";
            itemDetails.text = "A strong steel sword, made for a Viking soldier.   (+2 Attack)";
            itemValue.text = (350 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item1sc.image;
        }
        if (ID == 2 && sMace == false)
        {
            activeItem = item1sc;

            itemName.text = "Spiked Mace";
            itemDetails.text = "This mace is designed to do some damage.   (+2 Attack)";
            itemValue.text = (350 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item1sc.image;
        }
        if (ID == 3)
        {
            activeItem = item1sc;

            itemName.text = "Potion";
            itemDetails.text = "A regular size health potion. (+25 Health)";
            itemValue.text = (50 - (playerStats.Speech * 2)).ToString();

            itemBox.texture = item1sc.image;
        }
    }

    //This method shows the second item details, depending on ID//
    public void ShowItem2()
    {
        if (ID == 1 && vAxe == false)
        {
            activeItem = item2sc;

            itemName.text = "Viking Axe";
            itemDetails.text = "A strong steel axe, made for a Viking soldier.   (+2 Attack)";
            itemValue.text = (350 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item2sc.image;
        }
        if (ID == 2 && sCrusher == false)
        {
            activeItem = item2sc;

            itemName.text = "Skull Basher";
            itemDetails.text = "A powerful weapon, does exactly as it says it does.   (+3 Attack)";
            itemValue.text = (900 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item2sc.image;
        }
        if (ID == 3)
        {
            activeItem = item2sc;

            itemName.text = "Large Potion";
            itemDetails.text = "A large size health potion. (+50 Health)";
            itemValue.text = (100 - (playerStats.Speech * 2)).ToString();

            itemBox.texture = item2sc.image;
        }
    }


    //This method shows the third item details, depending on ID//
    public void ShowItem3()
    {
        if (ID == 1 && halberd == false)
        {
            activeItem = item3sc;

            itemName.text = "Halberd";
            itemDetails.text = "A halberd pike, standard issue weapon for town guards.   (+2 Attack)";
            itemValue.text = (410 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item3sc.image;
        }
        if (ID == 2 && naginata == false)
        {
            activeItem = item3sc;

            itemName.text = "Naginata";
            itemDetails.text = "The Naginata spears are used by elite Yurimoto warriors.   (+3 Attack)";
            itemValue.text = (1100 - (playerStats.Speech * 5)).ToString();

            itemBox.texture = item3sc.image;
        }
        if (ID == 3)
        {
            activeItem = item3sc;

            itemName.text = "Hackleberry";
            itemDetails.text = "Ripe hackleberries. Known to contain a lot of vitamins. (+20 Health)";
            itemValue.text = (40 - playerStats.Speech).ToString();

            itemBox.texture = item3sc.image;
        }
    }

    //This method shows the 4th shop item details, depending on ID//
    public void ShowItem4()
    {
        if (ID == 1)
        {
            activeItem = item4sc;

            itemName.text = "Boar Meat";
            itemDetails.text = "Fresh red meat from a wild boar. Full of protein when eaten. (+20 health)";
            itemValue.text = (25 - playerStats.Speech).ToString();

            itemBox.texture = item4sc.image;
        }
        if (ID == 2)
        {
            activeItem = item4sc;

            itemName.text = "Raw Fish";
            itemDetails.text = "Orange-Finned Perch, caught from the local rivers or lake. (+25 Health)";
            itemValue.text = (35 - playerStats.Speech).ToString();

            itemBox.texture = item4sc.image;
        }
        if (ID == 3)
        {
            activeItem = item4sc;

            itemName.text = "Corn";
            itemDetails.text = "Harvested corn, good for feeding animals, among other things. (+10 Health)";
            itemValue.text = (40 - playerStats.Speech).ToString();

            itemBox.texture = item4sc.image;
        }
    }


    //This method is called when the player buys an item
    public void BuyItem()
    {
        //VIKING VENDOR - SHOP 1//
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        if (activeItem.ID == 305 && playerScript.Count >= (350 - (playerStats.Speech * 5)) && vSword == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((350 - (playerStats.Speech * 5)));
            transactionTotal = transactionTotal - (350 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item1sc);

            //Set the box to blank and the bool as sold
            box1.texture = blankbox;
            vSword = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 302 && playerScript.Count >= (350 - (playerStats.Speech * 5)) && vAxe == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((350 - (playerStats.Speech*5)));
            transactionTotal = transactionTotal - (350 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item2sc);

            //Set the box to blank and the bool as sold
            box2.texture = blankbox;
            vAxe = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 311 && playerScript.Count >= (410 - (playerStats.Speech * 5)) && halberd == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((410 - (playerStats.Speech*5)));
            transactionTotal = transactionTotal - (410 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item3sc);

            //Set the box to blank and the bool as sold
            box3.texture = blankbox;
            halberd = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 102 && playerScript.Count >= (25 - playerStats.Speech))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((25 - playerStats.Speech));
            transactionTotal = transactionTotal - (25 - playerStats.Speech);
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item4sc);
        }

        //EASTERN VENDOR - SHOP 2//
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 308 && playerScript.Count >= (350 - (playerStats.Speech * 5)) && vSword == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((350 - (playerStats.Speech * 5)));
            transactionTotal = transactionTotal - (350 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item1sc);

            //Set the box to blank and the bool as sold
            box1.texture = blankbox;
            vSword = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 309 && playerScript.Count >= (900 - (playerStats.Speech * 5)) && vAxe == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((900 - (playerStats.Speech * 5)));
            transactionTotal = transactionTotal - (900 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item2sc);

            //Set the box to blank and the bool as sold
            box2.texture = blankbox;
            vAxe = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 312 && playerScript.Count >= (1100 - (playerStats.Speech * 5)) && halberd == false)
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((1100 - (playerStats.Speech * 5)));
            transactionTotal = transactionTotal - (1100 - (playerStats.Speech * 5));
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item3sc);

            //Set the box to blank and the bool as sold
            box3.texture = blankbox;
            halberd = true;
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 123 && playerScript.Count >= (35 - playerStats.Speech))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((35 - playerStats.Speech));
            transactionTotal = transactionTotal - (35 - playerStats.Speech);
            saleSound.Play();

            //Update the display
            ShowItem4();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item4sc);
        }

        //POTIONS VENDOR - SHOP 3//
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 128 && playerScript.Count >= (50 - (playerStats.Speech*2)))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((50 - (playerStats.Speech * 2)));
            transactionTotal = transactionTotal - (50 - (playerStats.Speech * 2));
            saleSound.Play();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item1sc);
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 129 && playerScript.Count >= (100 - (playerStats.Speech * 2)))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((100 - (playerStats.Speech * 2)));
            transactionTotal = transactionTotal - (100 - (playerStats.Speech * 2));
            saleSound.Play();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item2sc);
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 120 && playerScript.Count >= (40 - playerStats.Speech))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((40 - playerStats.Speech));
            transactionTotal = transactionTotal - (40 - playerStats.Speech);
            saleSound.Play();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item3sc);
        }
        //If the ID is correct on the item, the player can afford it, and they have not bought it already
        else if (activeItem.ID == 116 && playerScript.Count >= (40 - playerStats.Speech))
        {
            //Remove the gold, update the transaction total and play the sale sound
            playerScript.RemoveGold((40 - playerStats.Speech));
            transactionTotal = transactionTotal - (40 - playerStats.Speech);
            saleSound.Play();

            //Add the item to the player inventory
            playerInventory.AddItemShop(item4sc);
        }

    }


    //This method shows the helmet upgrade//
    public void ShowHeadUpgrade()
    {
        //Set the displayed upgrade depending on booleans
        if(helmet1 == false && helmet2 == false && helmet3 == false)
        {
            itemName.text = playerArmour.dwarvenHead.title;
            itemDetails.text = playerArmour.dwarvenHead.description;
            itemValue.text = (100 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.dwarvenHead.image;
        }
        else if (helmet1 == true && helmet2 == false && helmet3 == false)
        {
            itemName.text = playerArmour.steelHead.title;
            itemDetails.text = playerArmour.steelHead.description;
            itemValue.text = (250 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.steelHead.image;
        }
        else if (helmet1 == true && helmet2 == true && helmet3 == false)
        {
            itemName.text = playerArmour.elvenHead.title;
            itemDetails.text = playerArmour.elvenHead.description;
            itemValue.text = (500 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.elvenHead.image;
        }
        else if (helmet1 == true && helmet2 == true && helmet3 == true)
        {
            itemName.text = "N/A";
            itemDetails.text = "There are no more available upgrades for your helmet.";
            itemValue.text = "N/A";

            itemBox.texture = blankbox;
        }
    }


    //This method shows the body armour upgrade//
    public void ShowBodyUpgrade()
    {
        //Set the displayed upgrade depending on booleans
        if (body1 == false && body2 == false && body3 == false)
        {
            itemName.text = playerArmour.dwarvenBody.title;
            itemDetails.text = playerArmour.dwarvenBody.description;
            itemValue.text = (200 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.dwarvenBody.image;
        }
        else if (body1 == true && body2 == false && body3 == false)
        {
            itemName.text = playerArmour.steelBody.title;
            itemDetails.text = playerArmour.steelBody.description;
            itemValue.text = (750 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.steelBody.image;
        }
        else if (body1 == true && body2 == true && body3 == false)
        {
            itemName.text = playerArmour.elvenBody.title;
            itemDetails.text = playerArmour.elvenBody.description;
            itemValue.text = (1400 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.elvenBody.image;
        }
        else if (body1 == true && body2 == true && body3 == true)
        {
            itemName.text = "N/A";
            itemDetails.text = "There are no more available upgrades for your body armour.";
            itemValue.text = "N/A";

            itemBox.texture = blankbox;
        }
    }


    //This method shows the feet armour upgrade//
    public void ShowFeetUpgrade()
    {
        //Set the displayed upgrade depending on booleans
        if (feet1 == false && feet2 == false && feet3 == false)
        {
            itemName.text = playerArmour.dwarvenBoots.title;
            itemDetails.text = playerArmour.dwarvenBoots.description;
            itemValue.text = (100 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.dwarvenBoots.image;
        }
        else if (feet1 == true && feet2 == false && feet3 == false)
        {
            itemName.text = playerArmour.steelBoots.title;
            itemDetails.text = playerArmour.steelBoots.description;
            itemValue.text = (250 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.steelBoots.image;
        }
        else if (feet1 == true && feet2 == true && feet3 == false)
        {
            itemName.text = playerArmour.elvenBoots.title;
            itemDetails.text = playerArmour.elvenBoots.description;
            itemValue.text = (500 - (playerStats.Speech * 3)).ToString();

            itemBox.texture = playerArmour.elvenBoots.image;
        }
        else if (feet1 == true && feet2 == true && feet3 == true)
        {
            itemName.text = "N/A";
            itemDetails.text = "There are no more available upgrades for your boots.";
            itemValue.text = "N/A";

            itemBox.texture = blankbox;
        }
    }


    //This method is called when an armour upgrade is bought//
    public void BuyArmourUpgrade()
    {
        //DWARVEN ARMOUR
        //If the armour displayed is the correct armour and the player can afford it
        if(itemName.text == "Dwarven Cowl" && playerScript.Count >= (100 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((100 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (100 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeHead(1);
            saleSound.Play();
            helmet1 = true;

            //Update the display
            ShowBodyUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Dwarven Armour" && playerScript.Count >= (200 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((200 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (200 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeBody(1);
            saleSound.Play();
            body1 = true;

            //Update the display
            ShowFeetUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Dwarven Boots" && playerScript.Count >= (100 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((100 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (100 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeFeet(1);
            saleSound.Play();
            feet1 = true;

            //Update the display
            ShowBodyUpgrade();
        }

        //STEEL ARMOUR
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Steel Helmet" && playerScript.Count >= (250 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((250 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (250 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeHead(2);
            saleSound.Play();
            helmet2 = true;

            //Update the display
            ShowBodyUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Steel Armour" && playerScript.Count >= (750 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((750 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (750 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeBody(2);
            saleSound.Play();
            body2 = true;

            //Update the display
            ShowFeetUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Steel Boots" && playerScript.Count >= (250 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((250 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (250 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeFeet(2);
            saleSound.Play();
            feet2 = true;

            //Update the display
            ShowBodyUpgrade();
        }

        //ELVEN ARMOUR
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Elven Helmet" && playerScript.Count >= (500 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((500 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (500 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeHead(3);
            saleSound.Play();
            helmet3 = true;

            //Update the display
            ShowBodyUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Elven Armour" && playerScript.Count >= (1400 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((1400 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (1400 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeBody(3);
            saleSound.Play();
            body3 = true;

            //Update the display
            ShowFeetUpgrade();
        }
        //If the armour displayed is the correct armour and the player can afford it
        else if (itemName.text == "Elven Boots" && playerScript.Count >= (500 - (playerStats.Speech * 3)))
        {
            //Remove the gold and update the transaction total
            playerScript.RemoveGold((500 - (playerStats.Speech * 3)));
            transactionTotal = transactionTotal - (500 - (playerStats.Speech * 3));

            //Upgrade the armour, play the sale sound, set the bool
            playerArmour.UpgradeFeet(3);
            saleSound.Play();
            feet3 = true;

            //Update the display
            ShowBodyUpgrade();
        }
    }
}
