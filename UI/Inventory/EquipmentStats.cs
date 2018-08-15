using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentStats : MonoBehaviour {

    public GameObject player;           //Reference to the player
    playerController playerScript;      //The players controller script

    public Text attackText;             //The attack stat text component
    public Text defenseText;            //The defense stat text component

    public EquippedArmour head;         //The equipped helmet
    public EquippedArmour body;         //The equipped body armour
    public EquippedArmour feet;         //The equipped feet armour


    //Initialises the variables//
    void Start ()
    {
        playerScript = player.GetComponent<playerController>();
    }
	

    //Main update method//
	void Update () {

        //Update the attack to show the active weapon damage
        attackText.text = "ATTACK  +  " + playerScript.activeWeapon.damage.ToString();

        //Work out the players combined armour defense
        float defense;
        defense = head.equippedArmour.defense + body.equippedArmour.defense + feet.equippedArmour.defense;

        //Update the defense to show the combined armour defense
        defenseText.text = "DEFENSE  +  " + defense.ToString();
	}
}
