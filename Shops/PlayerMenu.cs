using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour {

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
    PlayerStats playerStats;                //The players stats

    public RawImage coinImage;              //Stores the coin image

    public AudioSource updateSound;         //The audio played when the details update
    private int num = 0;                    //Stops the sound playing on game start

    public Item activeItem;                 //The active item in the display

    public GameObject sellButton;           //The sell button game object
    public AudioSource sellSound;           //The sell sound

    public ShopMenu shop1;                  //Reference to a shopkeeper script
    public ShopMenu shop2;                  //Reference to a shopkeeper script
    public ShopMenu shop3;                  //Reference to a shopkeeper script
    public ShopMenu shop4;                  //Reference to a shopkeeper script


    //Initialises the variables//
    void Start()
    {
        //Sets up the UI components
        itemName = nameUI.GetComponent<Text>();
        itemDescription = descriptionUI.GetComponent<Text>();
        itemValue = valueUI.GetComponent<Text>();
        itemBox = GetComponent<RawImage>();

        //Sets up the script references
        playerScript = player.GetComponent<playerController>();
        playerInventory = player.GetComponent<Inventory>();
        playerHealth = player.GetComponent<PlayerHealth>();
        playerStats = player.GetComponent<PlayerStats>();

        //Shows an inital display
        ShowCoins();
    }


    //This method is called when an item is sold//
    public void SellItem()
    {
        //ITEMS//
        if (activeItem.ID == 102)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(102);
        }
        else if (activeItem.ID == 103)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(103);
        }
        else if (activeItem.ID == 104)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(104);
        }
        else if (activeItem.ID == 105)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(105);
        }
        else if (activeItem.ID == 106)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(106);
        }
        else if (activeItem.ID == 108)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(108);
        }
        else if (activeItem.ID == 109)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(109);
        }
        else if (activeItem.ID == 110)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(110);
        }
        else if (activeItem.ID == 112)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(112);
        }
        else if (activeItem.ID == 116)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(116);
        }
        else if (activeItem.ID == 117)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(117);
        }
        else if (activeItem.ID == 118)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(118);
        }
        else if (activeItem.ID == 120)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(120);
        }
        else if (activeItem.ID == 121)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(121);
        }
        else if (activeItem.ID == 122)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(122);
        }
        else if (activeItem.ID == 123)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(123);
        }
        else if (activeItem.ID == 124)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(124);
        }
        else if (activeItem.ID == 125)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(125);
        }
        else if (activeItem.ID == 126)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(126);
        }
        else if (activeItem.ID == 127)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(127);
        }
        else if (activeItem.ID == 128)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(128);
        }
        else if (activeItem.ID == 129)
        {
            //Work out the amount and remove it
            float amount = activeItem.value + playerStats.Speech;
            playerScript.Count += amount;

            //Update the transaction total
            shop1.transactionTotal = shop1.transactionTotal + amount;
            shop2.transactionTotal = shop2.transactionTotal + amount;
            shop3.transactionTotal = shop3.transactionTotal + amount;
            shop4.transactionTotal = shop4.transactionTotal + amount;

            //Play the sell sound, update the display, remove the item 
            sellSound.Play();
            ShowCoins();
            playerInventory.RemoveItem(129);
        }
    }


    //This method updates the inventory butttons//
    public void UpdateInventoryButtons()
    {
        //ITEMS//
        if (activeItem.ID == 101)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 102)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 103)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 104)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 105)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 106)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 107)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 108)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 109)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 110)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 111)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 112)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 113)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 114)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 115)
        {
            sellButton.SetActive(false);
        }
        else if (activeItem.ID == 116)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 117)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 118)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 120)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 121)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 122)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 123)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 124)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 125)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 126)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 127)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 128)
        {
            sellButton.SetActive(true);
        }
        else if (activeItem.ID == 129)
        {
            sellButton.SetActive(true);
        }
        //WEAPONS//
        else if (activeItem.ID >= 301 && activeItem.ID <= 312)
        {
            sellButton.SetActive(false);
        }

    }


    //Updates the display the show the players coin amount//
    public void ShowCoins()
    {
        itemName.text = "Gold";
        itemDescription.text = "Gold is the money of kings; silver is the money of gentlemen; barter is the money of peasants; but debt is the money of slaves.";
        itemValue.text = playerScript.Count.ToString();

        itemBox.texture = coinImage.texture;

        sellButton.SetActive(false);
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
