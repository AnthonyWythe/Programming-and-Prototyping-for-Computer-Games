using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float startingHealth = 100f;                         //The amount of health the player starts the game with
    public float currentHealth;                                 //The current health the player has
    public Slider healthSlider;                                 //Reference to the UI's health bar
    public Image damageImage;                                   //Reference to an image to flash on the screen
    public float flashSpeed = 5f;                               //The speed the damageImage will fade at
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     //The colour the damageImage is set to, to flash
    public Transform respawn;                                   //Location for the player to respawn at

    Animator anim;                                              //Reference to the Animator component
    playerController playerController;                          //Reference to the player's movement
    bool isDead;                                                //Whether the player is dead
    bool damaged;                                               //True when the player gets damaged

    public GameObject deathUI;                                  //The death UI object
    public Text coinsText;                                      //The display for coins lost when dead
    public AudioSource deathSound;                              //The death sound clip

    PlayerStats playerStats;                                    //Reference to the players stats
    float regenSpeed = 0.3f;                                    //Regen speed for the players health

    public EquippedArmour head;                                 //The players equipped head armour
    public EquippedArmour body;                                 //The players equipped body armour
    public EquippedArmour feet;                                 //The players equipped feet armour

    public GameObject healthNotif;                              //The health notification object
    public Text healthNotifText;                                //Health notification text
    bool healthUIactive = false;                                //Bool for the health notification
    float tempAmount;                                           //Temp amount for adding health
    float tempAmount2;                                          //Temp amount for removing health

    public ImageFade deathFade;                                 //Reference to the image fade


    //This method initialises the class//
    void Awake()
    {
        //Sets up animator variable
        anim = GetComponent<Animator>();

        //Sets up player controller variable
        playerController = GetComponent<playerController>();

        //Sets current health to the starting health
        currentHealth = startingHealth;

        //Initialises the player stats variable
        playerStats = GetComponent<PlayerStats>();

        //Inital fade in for the game
        deathFade.OnButtonClick();
    }


    //This is the main update mehtod for the class, runs damage image flash, checks for water/map death and removes death UI//
    void Update()
    {
        //If damaged, lets the damage image to the flash colour
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        //Set the damage image to fade over time
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        //Set damaged to false
        damaged = false;

        //If the player goes lower than accessible, set as dead
        if (this.gameObject.transform.position.y < 8)
        {
            Death();
        }

        //Set the slider value
        healthSlider.value = currentHealth;
    }


    //This method applys damage to the players health//
    public void TakeDamage(float amount)
    {
        //Set damaged to true for the flash image
        damaged = true;

        //Work out the damage with the players defense and armour
        float newAmount = (amount - (playerStats.Defense / 2) - (head.equippedArmour.defense + body.equippedArmour.defense + feet.equippedArmour.defense));

        //If the amount is more than 1, remove it from the health
        if(newAmount >= 1)
        {
            currentHealth -= newAmount;
        }
        //If the amount is less than 1, remove 1 from the health
        else if(newAmount < 1)
        {
            currentHealth -= 1;
        }

        //If the health display is unactive, make it active and show the amount of damage
        if (healthUIactive == false)
        {
            //Set the temp amount for the notification
            tempAmount2 = newAmount;

            //Show the notification and set the text
            healthNotif.SetActive(true);
            healthNotifText.text = "- " + newAmount.ToString();

            //Set the boolean for the notifcation
            healthUIactive = true;

            //Run the coroutine to delay removal of the notification
            StartCoroutine(DelayHealthNotif());
        }
        //If the health display is active, add the new amount to the displayed amount
        else if (healthUIactive == true)
        {
            newAmount = newAmount + tempAmount2;
            healthNotifText.text = "- " + newAmount.ToString();
            tempAmount2 = newAmount;
        }

        //If player health goes below 0, set as dead
        if (currentHealth <= 0)
        {
            Death();
        }
    }


    //This method applys damage to the players health//
    public void AddHealth(float amount)
    {
        //Checks the amount is not over full health
        if(currentHealth + amount > maxHealth)
        {
            amount = maxHealth - currentHealth;
        }

        //Add the amount to the current health
        currentHealth += amount;

        //Same as remove health (TakeDamage)
        if (healthUIactive == false)
        {
            tempAmount = amount;
            healthNotif.SetActive(true);
            healthNotifText.text = "+ " + amount.ToString();
            healthUIactive = true;
            StartCoroutine(DelayHealthNotif());
        }
        else if (healthUIactive == true)
        {
            amount = amount + tempAmount;
            healthNotifText.text = "+ " + amount.ToString();
            tempAmount = amount;
        }
    }


    //This method delays the coins add and minus UI//
    IEnumerator DelayHealthNotif()
    {
        yield return new WaitForSeconds(6);
        healthNotif.SetActive(false);
        healthUIactive = false;
        tempAmount = 0;
    }


    //This method is called when the players is dead//
    void Death()
    {
        //Sets the dead variable to true
        isDead = true;

        //Screen fade
        deathFade.OnButtonClick();

        //Respawn the player above the spawn point
        transform.position = respawn.position;
        transform.rotation = respawn.rotation;

        //Reset the current health and slider
        float healthIncrease = (maxHealth - currentHealth);
        AddHealth(healthIncrease);

        //Work out 2% of the players coins
        double amount;
        amount = playerController.Count * 0.03;

        //Round the number up or down
        int penalty = System.Convert.ToInt32(amount);

        //If the penalty is lower than 4, make it 3
        if(penalty < 4)
        {
            penalty = 3;
        }

        //Update the text for the penalty
        coinsText.text = "- " + penalty.ToString() + "  Gold";

        //Coin penalty for death and update the UI
        playerController.RemoveGold(penalty);
        playerController.SetCountText();

        //Play the death sound and activate the UI
        deathSound.Play();
        deathUI.SetActive(true);

        //Delay before removing the death sign
        StartCoroutine(Wait());
    }


    //This is called when the players endurance stat increases//
    public void UpdateHealth()
    {
        maxHealth = maxHealth + (playerStats.Endurance * 5);
        healthSlider.maxValue = maxHealth;
        regenSpeed = (0.3f + (playerStats.Endurance / 20));
    }


    //Delay before removing the death UI//
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(12);
        deathUI.SetActive(false);
    }
}