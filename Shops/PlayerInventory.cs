using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour {

    public Inventory playerInventory;   //Reference to the players inventory

    public RawImage box1;               //Box image in the UI
    public RawImage box2;               //Box image in the UI
    public RawImage box3;               //Box image in the UI
    public RawImage box4;               //Box image in the UI
    public RawImage box5;               //Box image in the UI
    public RawImage box6;               //Box image in the UI
    public RawImage box7;               //Box image in the UI
    public RawImage box8;               //Box image in the UI
    public RawImage box9;               //Box image in the UI
    public RawImage box10;              //Box image in the UI
    public RawImage box11;              //Box image in the UI
    public RawImage box12;              //Box image in the UI
    public RawImage box13;              //Box image in the UI
    public RawImage box14;              //Box image in the UI
    public RawImage box15;              //Box image in the UI
    public RawImage box16;              //Box image in the UI
    public RawImage box17;              //Box image in the UI
    public RawImage box18;              //Box image in the UI
    public RawImage box19;              //Box image in the UI
    public RawImage box20;              //Box image in the UI
    public RawImage box21;              //Box image in the UI
    public RawImage box22;              //Box image in the UI
    public RawImage box23;              //Box image in the UI
    public RawImage box24;              //Box image in the UI
    public RawImage box25;              //Box image in the UI
    public RawImage box26;              //Box image in the UI
    public RawImage box27;              //Box image in the UI

    public Texture blankBoxImg;         //Image for a blank inventory space

    public AudioSource addSound;        //The add sound


    //This method adds a new item to the inventory//
    public void AddItem(Item item)
    {
        //If the inventory is not full, add the item
        if (playerInventory.fullUp == false)
        {
            playerInventory.AddItem(item);
            addSound.Play();
        }
    }


    //This method removes an item from the inventory using ID numbers//
    public void RemoveItem(float ID)
    {
        foreach (Item item in playerInventory.Items)
        {
            if (item.ID == ID)
            {
                playerInventory.Items.Remove(item);
            }
        }
    }


    //The main update method, loads items into the inventory boxes//
    public void Update()
    {
        if (playerInventory.Items.Count == 0)
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
        if (playerInventory.Items.Count == 1)
        {
            box1.texture = playerInventory.Items[0].image;
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
        else if (playerInventory.Items.Count == 2)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
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
        else if (playerInventory.Items.Count == 3)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
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
        else if (playerInventory.Items.Count == 4)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
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
        else if (playerInventory.Items.Count == 5)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
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
        else if (playerInventory.Items.Count == 6)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
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
        else if (playerInventory.Items.Count == 7)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
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
        else if (playerInventory.Items.Count == 8)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
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
        else if (playerInventory.Items.Count == 9)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
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
        else if (playerInventory.Items.Count == 10)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
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
        else if (playerInventory.Items.Count == 11)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
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
        else if (playerInventory.Items.Count == 12)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
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
        else if (playerInventory.Items.Count == 13)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
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
        else if (playerInventory.Items.Count == 14)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
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
        else if (playerInventory.Items.Count == 15)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
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
        else if (playerInventory.Items.Count == 16)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
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
        else if (playerInventory.Items.Count == 17)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
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
        else if (playerInventory.Items.Count == 18)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
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
        else if (playerInventory.Items.Count == 19)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = blankBoxImg;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 20)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = blankBoxImg;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 21)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = blankBoxImg;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 22)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = blankBoxImg;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 23)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = playerInventory.Items[22].image;
            box24.texture = blankBoxImg;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 24)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = playerInventory.Items[22].image;
            box24.texture = playerInventory.Items[23].image;
            box25.texture = blankBoxImg;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 25)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = playerInventory.Items[22].image;
            box24.texture = playerInventory.Items[23].image;
            box25.texture = playerInventory.Items[24].image;
            box26.texture = blankBoxImg;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 26)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = playerInventory.Items[22].image;
            box24.texture = playerInventory.Items[23].image;
            box25.texture = playerInventory.Items[24].image;
            box26.texture = playerInventory.Items[25].image;
            box27.texture = blankBoxImg;
        }
        else if (playerInventory.Items.Count == 27)
        {
            box1.texture = playerInventory.Items[0].image;
            box2.texture = playerInventory.Items[1].image;
            box3.texture = playerInventory.Items[2].image;
            box4.texture = playerInventory.Items[3].image;
            box5.texture = playerInventory.Items[4].image;
            box6.texture = playerInventory.Items[5].image;
            box7.texture = playerInventory.Items[6].image;
            box8.texture = playerInventory.Items[7].image;
            box9.texture = playerInventory.Items[8].image;
            box10.texture = playerInventory.Items[9].image;
            box11.texture = playerInventory.Items[10].image;
            box12.texture = playerInventory.Items[11].image;
            box13.texture = playerInventory.Items[12].image;
            box14.texture = playerInventory.Items[13].image;
            box15.texture = playerInventory.Items[14].image;
            box16.texture = playerInventory.Items[15].image;
            box17.texture = playerInventory.Items[16].image;
            box18.texture = playerInventory.Items[17].image;
            box19.texture = playerInventory.Items[18].image;
            box20.texture = playerInventory.Items[19].image;
            box21.texture = playerInventory.Items[20].image;
            box22.texture = playerInventory.Items[21].image;
            box23.texture = playerInventory.Items[22].image;
            box24.texture = playerInventory.Items[23].image;
            box25.texture = playerInventory.Items[24].image;
            box26.texture = playerInventory.Items[25].image;
            box27.texture = playerInventory.Items[26].image;
        }
    }

}
