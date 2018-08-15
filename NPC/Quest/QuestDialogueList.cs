using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDialogueList : MonoBehaviour {

    public Quest quest1;        //The quest script
    public bool quest1open;     //Bool for the quests dialogue
    public Quest quest2;        //The quest script
    public bool quest2open;     //Bool for the quests dialogue
    public Quest quest3;        //The quest script
    public bool quest3open;     //Bool for the quests dialogue
    public Quest quest4;        //The quest script
    public bool quest4open;     //Bool for the quests dialogue
    public Quest quest5;        //The quest script
    public bool quest5open;     //Bool for the quests dialogue
    public Quest quest6;        //The quest script
    public bool quest6open;     //Bool for the quests dialogue
    public Quest quest7;        //The quest script
    public bool quest7open;     //Bool for the quests dialogue
    public Quest quest8;        //The quest script
    public bool quest8open;     //Bool for the quests dialogue
    public Quest quest9;        //The quest script
    public bool quest9open;     //Bool for the quests dialogue
    public Quest quest10;        //The quest script
    public bool quest10open;     //Bool for the quests dialogue
    public Quest quest11;        //The quest script
    public bool quest11open;     //Bool for the quests dialogue
    public Quest quest12;        //The quest script
    public bool quest12open;     //Bool for the quests dialogue
    public Quest quest13;        //The quest script
    public bool quest13open;     //Bool for the quests dialogue
    public Quest quest14;        //The quest script
    public bool quest14open;     //Bool for the quests dialogue
    public Quest quest15;        //The quest script
    public bool quest15open;     //Bool for the quests dialogue


    //Update method sets the bool to the bool in the quest script//
    public void Update()
    {
        quest1open = quest1.dialogueOpen;
        quest2open = quest2.dialogueOpen;
        quest3open = quest3.dialogueOpen;
        quest4open = quest4.dialogueOpen;
        quest5open = quest5.dialogueOpen;
        quest6open = quest6.dialogueOpen;
        quest7open = quest7.dialogueOpen;
        quest8open = quest8.dialogueOpen;
        quest9open = quest9.dialogueOpen;
        quest10open = quest10.dialogueOpen;
        quest11open = quest11.dialogueOpen;
        quest12open = quest12.dialogueOpen;
        quest13open = quest13.dialogueOpen;
        quest14open = quest14.dialogueOpen;
        quest15open = quest15.dialogueOpen;
    }
}
