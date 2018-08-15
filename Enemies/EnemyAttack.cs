using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;     //The time in seconds between each attack
    public int attackDamage = 10;               //The amount of health taken away per attack
    public AIHealth thisHealth;                 //Reference to the enemys own health

    GameObject player;                          //Reference to the player
    PlayerHealth playerHealth;                  //Reference to the player's health
    bool playerInRange;                         //Whether player is within the attack range
    float timer;                                //Timer for counting up to the next attack

    public GameObject mainBody;                 //Reference to the enemys main body object
    Animator animator;                          //Reference to the enemies animator component

    //Initialises the class and its variables//
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        animator = mainBody.GetComponent<Animator>();
    }


    //When player hits the trigger, set as in range//
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = true;
        }
    }


    //When the player exits the trigger, set to out of range//
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }


    //Main update method for the class, runs whether to attack or not//
    void Update()
    {
        //Iterates the timer value
        timer += Time.deltaTime;

        //If there has been enough time, the player is in the attack range, the enemy is not dead and is carrying out the attack animation - apply damage to the player//
        if (timer >= timeBetweenAttacks && playerInRange && thisHealth.isDead == false && animator.GetCurrentAnimatorStateInfo(0).IsName("attack") == true)
        {
            Attack();
        }
    }


    //This method is called when the player is being damaged//
    void Attack()
    {
        //Resets the attack timer
        timer = 0f;

        //If the player has health, damage by the attack amount
        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}