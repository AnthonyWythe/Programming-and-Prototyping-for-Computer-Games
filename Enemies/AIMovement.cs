using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AIMovement : MonoBehaviour
{

    public Transform hitPoint;          //Reference to the player hit point
    public Transform target;            //Reference to the player
    public Transform territory;         //Reference to the enemy territory
    public int proximity;               //The proximity from the territory
    public int MoveSpeed;               //The enemys movement speed
        
    Rigidbody rb;                       //Reference to the rigid body
    Animator anim;                      //Reference to the animator
    CapsuleCollider entity;             //Reference to the capsule collider

    float smooth = 2f;                  //The smooth value for rotation
    bool move = true;                   //Whether the enemy is moving or not

    public AIHealth thisHealth;         //Reference to the enemies own health
    public AudioSource attackSound;     //Attack sound for the enemy
    public bool attacking = false;      //Is the enemy attacking or not

    bool delay = false;                 //Boolean to aid in causing a delay on sound

    public GameObject healthUI;         //Reference to the enemys UI health bar
    public Slider healthBar;            //Reference to the slider component of the health bar

    bool attackOn = false;              //Bool to check if the enemy is in attack
    bool walking = false;               //Bool to check if the enemy is walking


    //This method initialises the class//
    void Start()
    {
        //Initalises all of the component references
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        entity = GetComponent<CapsuleCollider>();
    }

    //This is the main update method for the class//
    void Update()
    {
        //Checks the current animation sets the appropirate booleans
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("attack") == true)
        {
            attackOn = true;
            walking = false;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("walk") ==  true)
        {
            attackOn = false;
            walking = true;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("idle") == true)
        {
            attackOn = false;
            walking = false;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("die") == true)
        {
            attackOn = true;
            walking = false;
        }

        //If the player is within proximity of the territory and not attacking, move towards them
        if (Vector3.Distance(territory.position, target.position) <= proximity && attackOn == false)
        {
            //Transition for the animation
            anim.SetBool("PlayerLocated", true);

            //Rotate to face the player
            var lookPos = hitPoint.position - transform.position; lookPos.y = 0; var rotation = Quaternion.LookRotation(lookPos); transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);

            //Move towards the player
            rb.MovePosition(transform.position += transform.forward * MoveSpeed * Time.deltaTime);
        }

        //If the player is out of distance + 10, the enemy is not close enough to the territory and the enemy is attacking or dead; move towards the territory
        if (Vector3.Distance(territory.position, target.position) > (proximity + 10) && Vector3.Distance(territory.position, transform.position) > 5 && thisHealth.isDead == false && attackOn == false)
        {
            //Transition for the animation
            anim.SetBool("PlayerLocated", true);

            //Rotate to face the territory
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(territory.position - transform.position), smooth * Time.deltaTime);

            //Move towards the territory
            rb.MovePosition(transform.position += transform.forward * MoveSpeed * Time.deltaTime);
        }
        
        //If the player is out of distance and the enemy is close enough to the territory, stop moving
        if (Vector3.Distance(territory.position, target.position) > proximity && Vector3.Distance(territory.position, transform.position) < 5 && thisHealth.isDead == false 
            || Vector3.Distance(territory.position, target.position) > proximity && Vector3.Distance(territory.position, target.position) < (proximity+10) && Vector3.Distance(territory.position, transform.position) > 5 && thisHealth.isDead == false)
        {
            //Animation transition
            anim.SetBool("PlayerLocated", false);
        }

        //If the enemy is dead, set to dead and remove the colldier entity
        if(thisHealth.isDead == true)
        {
            anim.SetBool("Death", true);
            entity.enabled = false;
        }

        //If the enemy is attacking, play the attack sound, includes a delay
        if (attacking == true && delay == false && thisHealth.isDead == false)
        {
            AttackSound();
        }

        //If the player is within range, activate the enemies health display in the UI
        if(Vector3.Distance(territory.position, target.position) <= proximity && thisHealth.isDead == false)
        {
            healthUI.SetActive(true);
            healthBar.maxValue = thisHealth.maxHealth;
            healthBar.value = thisHealth.currentHealth;
        }
        //When the player is out of range, un active the health display
        else
        {
            healthUI.SetActive(false);
        }
    }


    //This method is used to play the attack sound//
    public void AttackSound()
    {
        //Play the sound
        attackSound.Play();

        //Set delay to true, and call the delay method
        delay = true;
        StartCoroutine(SoundDelay());
    }


    //Player is in attack range//
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("inRange", true);
            attacking = true;
        }
    }


    //Player is no longer in attack range//
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("inRange", false);
            attacking = false;
        }
    }


    //This method waits for a second, and then lets the update resume (lets the sound have exit time)//
    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(1);
        delay = false;
    }
}
