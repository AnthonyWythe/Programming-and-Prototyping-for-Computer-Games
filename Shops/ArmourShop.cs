using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmourShop : MonoBehaviour {

    public Text helmetValue;            //Helmet value on the UI
    public Text bodyValue;              //Body value on the UI
    public Text bootsValue;             //Boots value on the UI

    public RawImage helmetImage;        //Helmet image on the UI
    public RawImage bodyImage;          //Body image on the UI
    public RawImage bootsImage;         //Boots image on the UI

    public ShopMenu armourVendor;       //Reference to the armour vendor script

    public ArmourControl playerArmour;  //Reference to the player armour script
    public PlayerStats playerStats;     //Reference to the player stats script

    public Texture blankImg;            //The blank inventory box image


    //Main update method//
    void Update ()
    {
        //Run through correct helmet display
        if (armourVendor.helmet1 == false && armourVendor.helmet2 == false && armourVendor.helmet3 == false)
        {
            //Show the dwarven helmet
            helmetValue.text = (100 - (playerStats.Speech * 3)).ToString();
            helmetImage.texture = playerArmour.dwarvenHead.image;
        }
        else if (armourVendor.helmet1 == true && armourVendor.helmet2 == false && armourVendor.helmet3 == false)
        {
            //Show the steel helmet
            helmetValue.text = (250 - (playerStats.Speech * 3)).ToString();
            helmetImage.texture = playerArmour.steelHead.image;
        }
        else if (armourVendor.helmet1 == true && armourVendor.helmet2 == true && armourVendor.helmet3 == false)
        {
            //Show the elven helmet
            helmetValue.text = (500 - (playerStats.Speech * 3)).ToString();
            helmetImage.texture = playerArmour.elvenHead.image;
        }
        else if (armourVendor.helmet1 == true && armourVendor.helmet2 == true && armourVendor.helmet3 == true)
        {
            //Show no more upgrades
            helmetValue.text = "N/A";
            helmetImage.texture = blankImg;
        }

        //Run through the correct body armour display
        if (armourVendor.body1 == false && armourVendor.body2 == false && armourVendor.body3 == false)
        {
            //Show the dwaven body armour
            bodyValue.text = (200 - (playerStats.Speech * 3)).ToString();
            bodyImage.texture = playerArmour.dwarvenBody.image;
        }
        else if (armourVendor.body1 == true && armourVendor.body2 == false && armourVendor.body3 == false)
        {
            //Show the steel body armour
            bodyValue.text = (750 - (playerStats.Speech * 3)).ToString();
            bodyImage.texture = playerArmour.steelBody.image;
        }
        else if (armourVendor.body1 == true && armourVendor.body2 == true && armourVendor.body3 == false)
        {
            //Show the elven body armour
            bodyValue.text = (1400 - (playerStats.Speech * 3)).ToString();
            bodyImage.texture = playerArmour.elvenBody.image;
        }
        else if (armourVendor.body1 == true && armourVendor.body2 == true && armourVendor.body3 == true)
        {
            //Show no more upgrades
            bodyValue.text = "N/A";
            bodyImage.texture = blankImg;
        }

        //Run through the correct boots display
        if (armourVendor.feet1 == false && armourVendor.feet2 == false && armourVendor.feet3 == false)
        {
            //Show dwarven boots
            bootsValue.text = (100 - (playerStats.Speech * 3)).ToString();
            bootsImage.texture = playerArmour.dwarvenBoots.image;
        }
        else if (armourVendor.feet1 == true && armourVendor.feet2 == false && armourVendor.feet3 == false)
        {
            //Show steel boots
            bootsValue.text = (250 - (playerStats.Speech * 3)).ToString();
            bootsImage.texture = playerArmour.steelBoots.image;
        }
        else if (armourVendor.feet1 == true && armourVendor.feet2 == true && armourVendor.feet3 == false)
        {
            //Show elven boots
            bootsValue.text = (500 - (playerStats.Speech * 3)).ToString();
            bootsImage.texture = playerArmour.elvenBoots.image;
        }
        else if (armourVendor.feet1 == true && armourVendor.feet2 == true && armourVendor.feet3 == true)
        {
            //Show no more upgrades
            bootsValue.text = "N/A";
            bootsImage.texture = blankImg;
        }
    }
}
