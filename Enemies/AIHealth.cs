using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIHealth : MonoBehaviour
{

    public float startingHealth;                                //The amount of health the enemy starts with
    public float currentHealth;                                 //The current health of the enemy
    public float maxHealth;                                     //The max health of the enemy

    Animator anim;                                              //Reference to the Animator component
    playerController playerController;                          //Reference to the player's movement
    bool damaged = false;                                       //True when the enemy is damaged
    bool weaponInRange = false;                                 //Whether the players weapon is in range
    public AudioSource deathSound;                              //Sound for the enemies death
    public bool isDead = false;                                 //Whether the enemy is dead or not

    public GameObject respawnPoint;                             //The enemys respawn point
    public int respawnTime;                                     //How long till the enemy respawns
    public GameObject mainBody;                                 //The enemys main game object
    Animator animator;                                          //Reference to the main body animator component

    public float XP;                                            //The amount of XP the enemy is worth when killed
    public GameObject player;                                   //Reference to the player
    PlayerStats playerStats;                                    //Reference to the players stats

    public Image damageImage;                                   //Reference to an image to flash on the screen
    public float flashSpeed = 5f;                               //The speed the damageImage will fade at
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     //The colour the damageImage is set to, to flash

    public GameObject loot;                                     //The loot item that the enemy drops
    Item item;                                                  //The items cript attached to the loot item

    AIMovement movementScript;

    public GameObject healthNotif;                              //Notification for damaged health on the enemy
    public Text healthNotifText;                                //Text health value in the UI
    bool healthUIactive = false;                                //Bool for the state of the health notification
    float tempAmount;                                           //Temporary value of the health in the UI


    //Initialises the class, sets up references//
    void Awake()
    {
        //Sets up animatior variable
        animator = mainBody.GetComponent<Animator>();

        //Sets up player controller variable
        playerController = player.GetComponent<playerController>();

        //Sets the current health to the starting health
        currentHealth = startingHealth;

        //Sets the max health to the starting health
        maxHealth = startingHealth;

        //Sets up the reference to the player stats
        playerStats = player.GetComponent<PlayerStats>();

        //Reference to the loot item
        item = loot.GetComponent<Item>();

        //Sets up the reference to the enemy movement
        movementScript = mainBody.GetComponent<AIMovement>();
    }


    //Main update method for the class//
    void Update()
    {
        //If the weapon is colliding with the enemy, call the hurt method
        if (weaponInRange == true)
        {
            Hurt();
        }

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
    }


    //This method applies damage to the enemy//
    public void TakeDamage(float amount)
    {
        //Sets damaged to true
        damaged = true;

        //Lowers the current health by the damage amount
        currentHealth -= amount;

        //If the health display is unactive, make it active and show the amount of damage
        if (healthUIactive == false)
        {
            //Temporary amount
            tempAmount = amount;

            //Show notification and value
            healthNotif.SetActive(true);
            healthNotifText.text = "- " + amount.ToString();

            //Sets as active, run the coroutine
            healthUIactive = true;
            StartCoroutine(DelayHealthNotif());
        }
        //If the health display is already active, add the new amount to the displayed amount
        else if (healthUIactive == true)
        {
            amount = amount + tempAmount;
            healthNotifText.text = "- " + amount.ToString();
            tempAmount = amount;
        }


        //If enemy health is lower than 0, set to dead
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    //This method delays the removal of the health notification//
    IEnumerator DelayHealthNotif()
    {
        yield return new WaitForSeconds(6);
        healthNotif.SetActive(false);
        healthUIactive = false;
        tempAmount = 0;
    }

    //This method damages the enemies health//
    void Hurt()
    {
        //If not currently being damaged, call the take damage method (using the players weapon stat and attack stat as an input)
        if (damaged == false)
        {
            TakeDamage((playerController.activeWeapon.damage) + (playerStats.Attack/2));
        }
    }


    //This method is called when the enemy dies//
    void Death()
    {
        //Set the boolean to true and play the death sound
        isDead = true;
        deathSound.Play();

        //Reward the player with XP
        playerStats.AddXP(XP);

        //Spawn the loot items
        loot.SetActive(true);
        item.IsActive = true;

        //Starts the respawn method with a delay
        StartCoroutine(Respawn(respawnTime));
    }


    //This checks whether the players weapon is touching the enemy//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            weaponInRange = true;
        }
    }


    //This is called when the weapon has stopped touching the player//
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            weaponInRange = false;
            damaged = false;
        }
    }


    //This is a coroutine method for respawning the enemy//
    IEnumerator Respawn(int waitTime)
    {
        //Delay of two minutes before respawn
        yield return new WaitForSeconds(waitTime);

        //Reset the enemies health
        currentHealth = startingHealth;

        //Move and rotate the main body component of the enemy
        mainBody.transform.position = respawnPoint.transform.position;
        mainBody.transform.rotation = respawnPoint.transform.rotation;

        //Ensures attack sound is not looping
        movementScript.attacking = false;

        //Hide the loot if the player didn't collect it
        loot.SetActive(false);

        //Set the animator and boolean to bring the enemy back to life
        animator.SetBool("Death", false);
        isDead = false;
    }
}
