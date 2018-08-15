using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquippedArmour : MonoBehaviour {

    public RawImage equipmentImage;     //The image box for the equipped armour
    public Armour equippedArmour;       //The script for the equipped armour


    //Update the image to the same as the armour image//
	void Update ()
    {
        equipmentImage.texture = equippedArmour.image;	
	}


    //Equip a new armour//
    public void EquipArmour(Armour armour)
    {
        equippedArmour = armour;
    }
}
