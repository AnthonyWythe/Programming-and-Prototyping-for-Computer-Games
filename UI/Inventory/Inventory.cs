using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject fullNotif;        //The full up notification
    public bool fullUp = false;         //Bool for the notification

    List<Item> items;                   //The list of items, with get/set method
    public List<Item> Items
    {
        get { return items; }
    }

    public AudioSource addSound;        //Reference to the add sound
    public AudioSource equipSound;      //Reference to the equipd sound

    bool ownedItem;                     //Owned item boolean, with get/set method
    public bool OwnedItem
    {
        get { return ownedItem; }
        set { ownedItem = value; }
    }

    //All of the UI box image components
    public RawImage box1;
    public RawImage box2;
    public RawImage box3;
    public RawImage box4;
    public RawImage box5;
    public RawImage box6;
    public RawImage box7;
    public RawImage box8;
    public RawImage box9;
    public RawImage box10;
    public RawImage box11;
    public RawImage box12;
    public RawImage box13;
    public RawImage box14;
    public RawImage box15;
    public RawImage box16;
    public RawImage box17;
    public RawImage box18;
    public RawImage box19;
    public RawImage box20;
    public RawImage box21;
    public RawImage box22;
    public RawImage box23;
    public RawImage box24;
    public RawImage box25;
    public RawImage box26;
    public RawImage box27;

    public Texture blankBoxImg;         //Blank inventory image

    public Item boarMeat;               //Reference to the boar meat item script


    //This method initialises the variables//
    void Start ()
    {
        //Initialise the list of items
        items = new List<Item>();

        //Add boar meat to the player inventory
        items.Add(boarMeat);
        items.Add(boarMeat);
        items.Add(boarMeat);
    }

    //The main update method, loads items into the inventory boxes//
    public void Update()
    {
        //If the inventory is full up, set bool and show notif
        if(items.Count == 27)
        {
            fullUp = true;
            fullNotif.SetActive(true);
        }
        //Else if it isnt, set the bool and hide the notif
        else if(items.Count < 27)
        {
            fullUp = false;
            fullNotif.SetActive(false);
        }

        //Read the inventory total, and set the images boxes accordingly
        if(items.Count == 0)
        {
            box1.texture = blankBoxImg;
            box2.texture = blankBoxImg;
            box3.texture = blankBoxImg;
            box4.texture = blankBoxImg;
            box5.texture = blankBoxImg;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        if(items.Count == 1)
        {
            box1.texture = items[0].image;
            box2.texture = blankBoxImg;
            box3.texture = blankBoxImg;
            box4.texture = blankBoxImg;
            box5.texture = blankBoxImg;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if(items.Count == 2)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = blankBoxImg;
            box4.texture = blankBoxImg;
            box5.texture = blankBoxImg;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 3)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = blankBoxImg;
            box5.texture = blankBoxImg;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 4)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = blankBoxImg;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 5)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = blankBoxImg;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 6)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = blankBoxImg;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 7)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = blankBoxImg;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 8)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = blankBoxImg;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 9)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = blankBoxImg;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 10)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = blankBoxImg;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 11)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = blankBoxImg;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 12)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = blankBoxImg;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 13)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = blankBoxImg;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 14)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = blankBoxImg;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 15)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = blankBoxImg;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 16)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = blankBoxImg;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 17)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = blankBoxImg;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 18)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = blankBoxImg;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 19)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 20)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 21)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 22)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 23)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = items[22].image;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 24)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = items[22].image;
            box24.texture = items[23].image;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 25)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = items[22].image;
            box24.texture = items[23].image;
            box25.texture = items[24].image;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 26)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = items[22].image;
            box24.texture = items[23].image;
            box25.texture = items[24].image;
            box26.texture = items[25].image;
            box27.texture = blankBoxImg;
        }
        else if (items.Count == 27)
        {
            box1.texture = items[0].image;
            box2.texture = items[1].image;
            box3.texture = items[2].image;
            box4.texture = items[3].image;
            box5.texture = items[4].image;
            box6.texture = items[5].image;
            box7.texture = items[6].image;
            box8.texture = items[7].image;
            box9.texture = items[8].image;
            box10.texture = items[9].image;
            box11.texture = items[10].image;
            box12.texture = items[11].image;
            box13.texture = items[12].image;
            box14.texture = items[13].image;
            box15.texture = items[14].image;
            box16.texture = items[15].image;
            box17.texture = items[16].image;
            box18.texture = items[17].image;
            box19.texture = items[18].image;
            box20.texture = items[19].image;
            box21.texture = items[20].image;
            box22.texture = items[21].image;
            box23.texture = items[22].image;
            box24.texture = items[23].image;
            box25.texture = items[24].image;
            box26.texture = items[25].image;
            box27.texture = items[26].image;
        }
    }


    //This method adds a new item to the inventory//
    public void AddItem(Item item)
    {
        //If the inventory is not full, add the item
        if (fullUp == false)
        {
            items.Add(item);
            addSound.Play();
        }
    }


    //This method adds a new item to the inventory without sound//
    public void AddItemWeapon(Item item)
    {
        //If the inventory is not full, add the item
        if (fullUp == false)
        {
            items.Add(item);
            equipSound.Play();
        }
    }


    //This method adds a new item to the inventory without sound//
    public void AddItemShop(Item item)
    {
        //If the inventory is not full, add the item
        if (fullUp == false)
        {
            items.Add(item);
        }
    }


    //This methods removes an item from the inventory using ID numbers//
    public void RemoveItem(float ID)
    {
        //Bool to make sure only one item is removed
        bool removed = false;

        //Look through the inventory
        foreach (Item item in items.ToArray())
        {
                if (item.ID == ID && removed == false)
                {
                    items.Remove(item);
                    removed = true;
                }

        }
    }


    //This method checks a players inventory for a specific item//
    public void CheckForItem(float ID)
    {
        foreach(Item item in items)
        {
            if(item.ID == ID)
            {
                ownedItem = true;
            }
        }
    }
}
