using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public float currentXP = 0f;        //The current XP the player has
    float startingXP = 0f;              //Startup XP amount
    public Slider XPSlider;             //Reference to the XP slider
    public Text XPNum;                  //UI display of the current XP
    public Text levelText;              //UI display of the current level
    public float level = 1f;                   //The current level of the player
    public Text skillPointsText;        //UI display of available skill points
    float skillPoints = 0f;             //Available skill points
    public GameObject plusSigns;        //The + signs on the UI
    public AudioSource levelUpSound;    //Audio clip of the level up sound
    public AudioSource music;           //Reference to the in game music
    public GameObject levelUpUI;        //The level up UI display
    public Text levelUpText;            //The level on the UI popup
    float max = 100f;                   //The max amount of XP before levelling up

    float attack;                   //Attack stat with get/set method
    public float Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    float defense;                  //Defense stat with get/set method
    public float Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    float endurance;                //Endurance stat with get/set method
    public float Endurance
    {
        get { return stamina; }
        set { stamina = value; }
    }

    float stamina;                  //Stamina stat with get/set method
    public float Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    float speed;                    //Speed stat with get/set method
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    float speech;                   //Speech stat with get/set method
    public float Speech
    {
        get { return speech; }
        set { speech = value; }
    }

    public Text attackText;         //Attack stat text display in the UI
    public Text defenseText;        //Defense stat text display in the UI
    public Text enduranceText;      //Endurance stat text display in the UI
    public Text staminaText;        //Stamina stat text display in the UI
    public Text speedText;          //Speed stat text display in the UI
    public Text speechText;         //Speech stat text display in the UI

    PlayerHealth playerHealth;      //Reference to the player health
    playerController playerStamina; //Reference to the player controlerr

    public bool levelled = false;   //Whether the player has just levelled or not

    public AudioSource skillClick;  //Audio for adding a point

    public GameObject XpNotif;      //The xp notification on the UI
    public Text XpNotifText;        //The text component for the notification

    public GameObject XpSound;
    AudioSource XpAudio;

    public GameObject attPlus;      //Plus sign for the attack stat
    public GameObject defPlus;      //Plus sign for the defense stat
    public GameObject endPlus;      //Plus sign for the endurance stat
    public GameObject stmPlus;      //Plus sign for the stamina stat
    public GameObject spdPlus;      //Plus sign for the speed stat
    public GameObject spcPlus;      //Plus sign for the speech stat


    //This method initialises the class//
    void Awake()
    {
        //Sets current XP to the starting XP
        currentXP = startingXP;

        //Set the slider value
        XPSlider.value = currentXP;

        //Sets up the script references
        playerHealth = GetComponent<PlayerHealth>();
        playerStamina = GetComponent<playerController>();

        //Sets the UI level display
        levelText.text = level.ToString();

        //Initialises the stats menu
        SetStats();

        //Sets up the reference to the XP sound
        XpAudio = XpSound.GetComponent<AudioSource>();
    }


    //Main update method for the class//
    public void Update()
    {
        //Sets the text display of the current XP in the UI
        XPNum.text = currentXP.ToString() + " / " + max.ToString();

        //Sets the text display for available skill points in the UI
        skillPointsText.text = "Available Points:   " + skillPoints.ToString();

        //If the player has available points, activate the plus signs
        if (skillPoints > 0)
        {
            plusSigns.SetActive(true);
        }
        else if (skillPoints == 0)
        {
            plusSigns.SetActive(false);
        }

        //These conditions stop a skill going higher than 5
        if(attack >= 5)
        {
            attPlus.SetActive(false);
        }
        else if(defense >= 5)
        {
            defPlus.SetActive(false);
        }
        else if (endurance >= 5)
        {
            endPlus.SetActive(false);
        }
        else if (stamina >= 5)
        {
            stmPlus.SetActive(false);
        }
        else if (speed >= 5)
        {
            spdPlus.SetActive(false);
        }
        else if (speech >= 5)
        {
            spcPlus.SetActive(false);
        }


    }

    //This method adds XP to the players current XP//
    public void AddXP(float amount)
    {
        //Ensures method is called once in update
        levelled = false;

        //Add current XP to the input amount
        currentXP += amount;

        XpNotif.SetActive(true);
        XpNotifText.text = "+ " + amount.ToString() + " XP";
        StartCoroutine(ExpNotif());

        //Set the slider value
        XPSlider.value = currentXP;

        //If player health goes above the max value, call the level up method
        if (currentXP >= max && levelled == false)
        {
            LevelUp();
        }


    }


    //This method is called to level up the player//
    public void LevelUp()
    {
        //Local variable for the new XP amount
        float newXP;

        //Take away the max value from the current value
        newXP = currentXP - max;

        //Set the remainder as the new XP amount
        currentXP = newXP;

        //Pause the music and play the level up sound
        music.volume = 0.01f;
        levelUpSound.Play();

        //Set the slider value
        XPSlider.value = currentXP;

        //Add another 20 to the max value
        max = max + 30f;

        //Increase the level by 1, add a new skill point, and set the stats menu again
        level = level + 1f;
        skillPoints = skillPoints + 1f;
        SetStats();

        //Change the text of the UI display for the level
        levelText.text = level.ToString();

        //Refresh the players health
        float healthIncrease = (playerHealth.maxHealth - playerHealth.currentHealth);
        playerHealth.AddHealth(healthIncrease);

        //Set the state to levelled
        levelled = true;

        //Level text setting
        levelUpText.text = level.ToString();

        //Switch on the level up UI
        levelUpUI.SetActive(true);

        //Call a delay method before removing the level up UI
        StartCoroutine(Wait());  
    }


    //This method updates the text on the statistics menu//
    public void SetStats()
    {
        attackText.text = attack.ToString();
        defenseText.text = defense.ToString();
        enduranceText.text = endurance.ToString();
        staminaText.text =  stamina.ToString();
        speedText.text = speed.ToString();
        speechText.text = speech.ToString();
    }


    //This method delays before removing the level up UI and resuming the music//
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(8);
        levelUpUI.SetActive(false);
        music.volume = 0.05f;
    }


    //This method delays the dissapearence of the Xp notif on the UI//
    IEnumerator ExpNotif()
    {
        XpAudio.Play();
        yield return new WaitForSeconds(6);
        XpNotif.SetActive(false);
    }


    //This method raises the attack stat//
    public void AttackStatPlus()
    {
        if (skillPoints > 0)
        {
            attack = attack + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }


    //This method raises the defense stat//
    public void DefenseStatPlus()
    {
        if (skillPoints > 0)
        {
            defense = defense + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }


    //This method raises the endurance stat//
    public void EnduranceStatPlus()
    {
        if (skillPoints > 0)
        {
            endurance = endurance + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }


    //This method raises the stamina stat//
    public void StaminaStatPlus()
    {
        if (skillPoints > 0)
        {
            stamina = stamina + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }


    //This method raises the speed stat//
    public void SpeedStatPlus()
    {
        if (skillPoints > 0)
        {
            speed = speed + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }


    //This method raises the speech stat//
    public void SpeechStatPlus()
    {
        if (skillPoints > 0)
        {
            speech = speech + 1f;
            skillPoints = skillPoints - 1f;
        }

        SetStats();

        skillClick.Play();
    }
}
