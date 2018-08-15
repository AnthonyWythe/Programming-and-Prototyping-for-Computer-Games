using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour {

    public GameObject levelUpUI;        //The UI graphic display
    PlayerStats playerStats;            //Reference to the players stats


    //Initialises the variables//
    public void Start()
    {
        playerStats = GetComponent<PlayerStats>();
    }


    //When the player stats level up, call the main method//
    void Update ()
    {
		if(playerStats.levelled == true)
        {
            StartCoroutine(Wait());
        }
	}


    //Coroutine that displays the UI, waits, then hides it//
    IEnumerator Wait()
    {
        levelUpUI.SetActive(true);
        yield return new WaitForSeconds(5);
        levelUpUI.SetActive(false);
    }
}
