using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLog : MonoBehaviour {

    public AIHealth scorpion1;      //Scorpion health script
    public AIHealth scorpion2;      //Scorpion health script
    public bool scorpion1dead;      //Scorpion death bool
    public bool scorpion2dead;      //Scorpion death bool

    public AIHealth goblin4;        //Goblin health script
    public AIHealth goblin5;        //Goblin health script
    public AIHealth goblin6;        //Goblin health script
    public bool goblin4dead;        //Goblin death bool
    public bool goblin5dead;        //Goblin death bool
    public bool goblin6dead;        //Goblin death bool

    public AIHealth bear;           //Beat health script
    public AIHealth crocodile;      //Crocodile health script
    public bool bearDead;           //Bear death bool
    public bool crocodileDead;      //Crocodile death bool

    public AIHealth boar1;          //Boar health script
    public AIHealth boar2;          //Boar health script
    public bool boar1dead;          //Boar death bool
    public bool boar2dead;          //Boar death bool


    //Main update method sets all of the health script death bools to this scripts death bools//
    void Update ()
    {
        scorpion1dead = scorpion1.isDead;
        scorpion2dead = scorpion2.isDead;

        goblin4dead = goblin4.isDead;
        goblin5dead = goblin5.isDead;
        goblin6dead = goblin6.isDead;

        bearDead = bear.isDead;
        crocodileDead = crocodile.isDead;

        boar1dead = boar1.isDead;
        boar2dead = boar2.isDead;
	}
}
