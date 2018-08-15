using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocation : MonoBehaviour {

    public bool active = false;     //Bool for the map location being active
    public GameObject mapPanel;     //The map panel on the UI


    //If the player is in range, set the bool and show the map panel
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            active = true;
            mapPanel.SetActive(true);
        }
    }


    //If the player is out of range, set the bool and hide the map panel
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            active = false;
            mapPanel.SetActive(false);
        }
    }

}
