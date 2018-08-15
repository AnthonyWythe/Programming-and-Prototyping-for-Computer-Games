using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Runestone : MonoBehaviour
{

    public PlayerHealth playerHealth;                       //Reference to the players health               
    public Slider healthSlider;                             //Reference to the health slider
    bool healing = false;                                   //Whether the player is healing or not
    bool recharging = false;                                //Can the runestone be used
    public GameObject UI;                                   //The popup when the runestone is used
    Light light;                                            //Reference to the light on the stone
    public AudioSource healingSound;                        //Audiosource reference


    //Initialise the reference to the light component//
    void Start()
    {
        light = GetComponent<Light>();
    }


    //If the player is in range, start healing//
    public void OnTriggerEnter(Collider other)
    {
        //If the player is in range and health is less than full, and the stone can be used
        if (other.gameObject.CompareTag("Player") && playerHealth.currentHealth < playerHealth.maxHealth && recharging == false)
        {
            //Work out the difference
            float difference;
            difference = playerHealth.maxHealth - playerHealth.currentHealth;
            
            //Heal the player to full health, or +40
            if(difference >= 40)
            {
                playerHealth.AddHealth(40);
            }
            else if(difference < 40)
            {
                playerHealth.AddHealth(difference);
            }
            else if(difference == 0)
            {
                //Do nothing
            }

            //Update health slider
            healthSlider.value = playerHealth.currentHealth;

            //Dim the light
            light.intensity = 1f;

            //Coroutine for the notification
            StartCoroutine(DelayUI());

            //Coroutine for recharging
            StartCoroutine(Recharge());
        }
    }


    //Coroutine for recharging
    IEnumerator Recharge()
    {
        recharging = true;
        yield return new WaitForSeconds(60);
        light.intensity = 4f;
        recharging = false;
    }


    //Coroutine for the notification
    IEnumerator DelayUI()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(6);
        UI.SetActive(false);
    }
}

