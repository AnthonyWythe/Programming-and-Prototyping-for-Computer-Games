using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathText : MonoBehaviour {


    public GameObject deathUI;           //The death UI object


    //If the player is in range, remove the UI
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deathUI.SetActive(false);
        }
    }
}
