using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourControl : MonoBehaviour {

    PlayerHealth playerHealth;              //Reference to the players health

    public EquippedArmour equippedHead;     //Reference to the equipped head armour
    public EquippedArmour equippedBody;     //Reference to the equipped body armour
    public EquippedArmour equippedFeet;     //Reference to the equipped feet armour

    public Armour leatherHead;              //Leather head armour
    public Armour leatherBody;              //Leather body armour
    public Armour leatherBoots;             //Leather feet armour

    public Armour dwarvenHead;              //Dwarven head armour
    public Armour dwarvenBody;              //Dwarven body armour
    public Armour dwarvenBoots;             //Dwarven feet armour

    public Armour steelHead;                //Steel head armour
    public Armour steelBody;                //Steel body armour
    public Armour steelBoots;               //Steel feet armour

    public Armour elvenHead;                //Elven head armour
    public Armour elvenBody;                //Elven body armour
    public Armour elvenBoots;               //Elven feet armour


    //Initialises the player health script//
    public void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }


    //This method upgrades the helmet on the player, depending on level//
    public void UpgradeHead(int upgradeLevel)
    {
        if(upgradeLevel == 1)
        {
            equippedHead.equippedArmour.equipped = false;
            equippedHead.EquipArmour(dwarvenHead);
            equippedHead.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 2)
        {
            equippedHead.equippedArmour.equipped = false;
            equippedHead.EquipArmour(steelHead);
            equippedHead.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 3)
        {
            equippedHead.equippedArmour.equipped = false;
            equippedHead.EquipArmour(elvenHead);
            equippedHead.equippedArmour.equipped = true;
        }
    }


    //This method upgrades the main body armour on the player, depending on level//
    public void UpgradeBody(int upgradeLevel)
    {
        if (upgradeLevel == 1)
        {
            equippedBody.equippedArmour.equipped = false;
            equippedBody.EquipArmour(dwarvenBody);
            equippedBody.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 2)
        {
            equippedBody.equippedArmour.equipped = false;
            equippedBody.EquipArmour(steelBody);
            equippedBody.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 3)
        {
            equippedBody.equippedArmour.equipped = false;
            equippedBody.EquipArmour(elvenBody);
            equippedBody.equippedArmour.equipped = true;
        }
    }


    //This method upgrades the boots on the player, depending on level//
    public void UpgradeFeet(int upgradeLevel)
    {
        if (upgradeLevel == 1)
        {
            equippedFeet.equippedArmour.equipped = false;
            equippedFeet.EquipArmour(dwarvenBoots);
            equippedFeet.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 2)
        {
            equippedFeet.equippedArmour.equipped = false;
            equippedFeet.EquipArmour(steelBoots);
            equippedFeet.equippedArmour.equipped = true;
        }
        else if (upgradeLevel == 3)
        {
            equippedFeet.equippedArmour.equipped = false;
            equippedFeet.EquipArmour(elvenBoots);
            equippedFeet.equippedArmour.equipped = true;
        }
    }

}
