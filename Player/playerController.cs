using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    bool jumping = false;                   //Is the player jumping 
    public bool Jumping                     //Get/set method for jumping
    {
        get { return jumping; }
        set { jumping = value; }
    }

    bool exhausted = false;                 //Is the player out of stamina
    public bool Exhausted                   //Get/set method for exhaustion
    {
        get { return exhausted; }
    }

    PlayerStats playerStats;                //Reference to the player stats

    public Slider staminaSlider;            //The stamina slider 
    public float maxStamina = 100f;         //Max stamina value
    public float startingStamina = 100f;    //Starting stamina value
    public float currentStamina;            //Current stamina value
    float regenSpeed = 5f;                  //Regen speed of the stamina value

    public GameObject mainHub;              //Reference to the main hub on the UI

    public float speed;                     //The players speed
    public Text countText;                  //The UI object to display the players coins
    public AudioSource coinSound;           //The sound for coin pickup
    private Rigidbody rb;                   //The players rigid body component
    float count;                            //The players coin count with a get/set method
    public float Count
    {
        get
        {
            return count;
        }

        set
        {
            count = value;
        }
    }


    public Weapon activeWeapon;             //Players active weapon
    public Weapon unactiveWeapon;           //Players unactive weapon 

    private Weapon tempWeapon;              //Temporary weapon variable for swap
    private bool swapped = false;           //Boolean for swapping

    public GameObject coinsNotif;           //The coin notification
    public Text coinsNotifText;             //Coin ntofication text
    bool coinsUIActive = false;             //Bool for coins notification
    float tempAmount;                       //Temporary amount for coin notifcation

    Inventory playerInventory;              //Reference to the players inventory
    public ItemDetails itemMenu;            //Reference to the player inventory display


    //The start method initialises the class//
    void Start()
    {
        //Sets up the rigid body component
        rb = GetComponent<Rigidbody>();

        //Sets the players coins to 0
        Count = 0;

        //Set the current stamina to the starting stamina
        currentStamina = startingStamina;

        //Initialise the player stats and inventory
        playerStats = GetComponent<PlayerStats>();
        playerInventory = GetComponent<Inventory>();
    }


    //The fixed update method moves the rigid body of the player//
    void FixedUpdate()
    {
        //Direction variables
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Sets up the direction to move in
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //Moves the player
        rb.AddForce(movement * speed);
    }

    //The update method loads the players coin text, opens/closes the buttons menu, closes the start dialogue and runs the attack function//
    private void Update()
    {
        //Update the players coin amount to the UI
        SetCountText();

        //If the left-click is pressed, run the attack function
        if (Input.GetMouseButtonDown(0))
        {
            activeWeapon.Attack();
        }

        //If Y is pressed, run the swap weapon method
        if (Input.GetKey(KeyCode.Y) && swapped == false)
        {
            SwapWeapon();
        }

        //If holding shift and not jumping, lower stamina value
        if (Input.GetKey(KeyCode.LeftShift) & jumping == false)
        {
            currentStamina = currentStamina - 0.2f;
        }

        //When space is pressed, run the jump function
        if (Input.GetKey(KeyCode.Space) & jumping == false)
        {
            Jump();
        }

        //Stops stamina value going below 0
        if (currentStamina < 0f)
        {
            currentStamina = 0f;
        }

        //If the player has no stamina, set state to exhausted
        if (currentStamina <= 0f)
        {
            exhausted = true;
        }
        else
        {
            exhausted = false;
        }

        //If the player is not at full stamina, regenerate its value over time
        if (currentStamina < maxStamina)
        {
            currentStamina += regenSpeed * Time.deltaTime;
        }

        //Update the UI slider value
        staminaSlider.value = currentStamina;
    }


    //This is called when the stamina stat is changed//
    public void UpdateStamina()
    {
        maxStamina = maxStamina + (playerStats.Stamina * 5);
        staminaSlider.maxValue = maxStamina;
    }


    //This method removes some stamina jor jumping//
    public void Jump()
    {
        currentStamina = currentStamina - 5f;
        jumping = true;
    }


    //Collision method to pickup coins//
    void OnTriggerEnter(Collider other)
    {
        //If the othe object is tagged 'pickup', delete, add to count and play sound
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //Remove coin object
            other.gameObject.SetActive(false);

            //Add coins to count
            AddGold(3);

            //Play the coin sound
            coinSound.Play();
        }
    }


    //This method sets the coin count text//
    public void SetCountText()
    {
        //Update the UI to display the coin amount as a string
        countText.text = Count.ToString();
    }


    //This weapon swaps the weapons between unactive and active//
    public void SwapWeapon()
    {
        //Copy and then hide the active weapon
        tempWeapon = activeWeapon;
        activeWeapon.gameObject.SetActive(false);

        //Set the unactive weapon to be the active weapon
        activeWeapon = unactiveWeapon;
        activeWeapon.gameObject.SetActive(true);

        //Paste the old active weapon as the new unactive weapon
        unactiveWeapon = tempWeapon;

        //Set state to swapped - call coroutine to delay instant swapping
        swapped = true;
        StartCoroutine(Wait());
    }



    //This weapon swaps the weapons between unactive and active, from the user interface//
    public void SwapWeaponUI()
    {
        //Copy and then hide the active weapon
        tempWeapon = activeWeapon;
        activeWeapon.gameObject.SetActive(false);

        //Set the unactive weapon to be the active weapon
        activeWeapon = unactiveWeapon;
        activeWeapon.gameObject.SetActive(true);

        //Paste the old active weapon as the new unactive weapon
        unactiveWeapon = tempWeapon;
    }


    //Makes the player wait 3 seconds between swapping weapons//
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        swapped = false;
    }

    
    //Add gold//
    public void AddGold(float amount)
    {
        //Add the amount to the current gold
        count = count + amount;

        //If the notifcation is not active
        if (coinsUIActive == false)
        {
            //Set up the temp amount
            tempAmount = amount;

            //Set the notfication and text
            coinsNotif.SetActive(true);
            coinsNotifText.text = "+ " + amount.ToString();

            //Set the boolean
            coinsUIActive = true;

            //Run the coroutine to delay removal
            StartCoroutine(DelayCoinsNotif());
        }
        else if(coinsUIActive == true)
        {
            amount = amount + tempAmount;
            coinsNotifText.text = "+ " + amount.ToString();
            tempAmount = amount;
        }
    }
    //Remove gold//
    public void RemoveGold(float amount)
    {
        //Remove the amount from the current gold
        count = count - amount;

        //If the notification is not active
        if (coinsUIActive == false)
        {
            //Show the notification and set the text
            coinsNotif.SetActive(true);
            coinsNotifText.text = "- " + amount.ToString();

            //Set the boolean as active
            coinsUIActive = true;

            //Run the coroutine to delay removal
            StartCoroutine(DelayCoinsNotif());
        }
    }


    //This method delays the coins notification//
    IEnumerator DelayCoinsNotif()
    {
        yield return new WaitForSeconds(6);
        coinsNotif.SetActive(false);
        coinsUIActive = false;
        tempAmount = 0;
    }


    //This method equips a new weapon//
    public void EquipWeapon(Weapon weapon, float ID)
    {
        //Add the active weapons item to the inventory
        playerInventory.AddItemWeapon(activeWeapon.matchingItem);

        //Adds the weapon script
        activeWeapon = weapon;

        //Remove the new weapon from the inventory
        playerInventory.RemoveItem(ID);
    }
}
