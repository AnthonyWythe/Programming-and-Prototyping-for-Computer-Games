using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour {


    public PlayerHealth playerHealth;                       //Reference to the players health               
    public Slider healthSlider;                             //Reference to the health slider
    public playerController playerScript;                   //Reference to the player stamina
    public Slider staminaSlider;                            //Reference to the stamina slider

    bool healing = false;                                   //Whether the player is healing or not
    bool recharging = false;                                //Can the bed be used
    public GameObject UI;                                   //The popup when the bed is used
    bool inRange = false;                                   //Is the player in range of the bed
    public GameObject notif;                                //Pop up notification for use
    public ImageFade screenFade;                            //Reference to the screen fade


    //Main update method
    void Update()
    {
        //If the player is in range, has low health, the bed can be used and they press the E key; call the rest funtion
        if(inRange == true && playerHealth.currentHealth < playerHealth.maxHealth && recharging == false && Input.GetKeyDown(KeyCode.E))
        {
            Rest();
        }
    }


    //This method is called when the player uses the bed//
    public void Rest()
    {
        //Screenfade
        screenFade.OnButtonClick();

        //Work out the amount between current health and full health
        float tempHealth = playerHealth.maxHealth - playerHealth.currentHealth;

        //Heal the player to full health
        playerHealth.AddHealth(tempHealth);

        //Rest the player to full stamina
        playerScript.currentStamina = playerScript.maxStamina;

        //Update the stamina slider
        staminaSlider.value = playerScript.currentStamina;

        //Courotuine for the notification
        StartCoroutine(DelayUI());

        //Couroutine for recharging
        StartCoroutine(Recharge());
    }


    //When the player is in range, set the bool and show the notification//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            notif.SetActive(true);
        }
    }


    //When the player is out of range, set the bool and hide the notification//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            notif.SetActive(false);
        }
    }


    //Courotuine for recharging//
    IEnumerator Recharge()
    {
        recharging = true;
        yield return new WaitForSeconds(20);
        recharging = false;
    }


    //Courotuine for the notification//
    IEnumerator DelayUI()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(6);
        UI.SetActive(false);
    }
}
