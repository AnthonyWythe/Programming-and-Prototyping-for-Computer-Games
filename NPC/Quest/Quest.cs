using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {

    public int ID;                      //The ID number of the quest
    string title;                       //The quest title with get/set method
    public string Title
    {
        get { return title; }
    }
    string person;                      //Name of the person giving the quest
    public string Person
    {
        get { return person; }
    }
    string location;                    //Location of the person giving the quest
            
    int loot;                           //The coin reward for completion
    float XP;                           //The XP reward for completion

    string currentDialogue;             //The current dialogue of the NPC
    string startDialogue;               //The start mission dialogue
    string activeDialogue;              //The dialogue when the mission is active
    string endDialogue;                 //The dialogue when the mission has ended

    public GameObject dialogueBox;      //Reference to the UI object for speech
    public Text dialogueBoxText;        //The text component of the UI object
    public Text questStateText;         //The text component of the quest state in the UI
    public GameObject crosshair;        //Reference to the crosshair on the UI

    string logEntry;                    //The log entry for the quest with get/set method
    public string LogEntry
    {
        get { return logEntry; }
    }
    string activeEntry;                 //The active entry
    string endEntry;                    //The ended entry

    bool inRange;                       //Whether the player is in speaking range
    public bool questStarted = false;   //Quest state
    bool questActive;                   //Quest state
    bool questEnded;                    //Quest state
    public bool finished = false;       //Quest state

    public AudioSource startQuestSound; //The start quest sound
    public AudioSource endQuestSound;   //The end quest sound

    public GameObject player;           //Reference to the player
    PlayerStats playerStats;            //The player stats
    playerController playerScript;      //The player controller script
    Inventory playerInventory;          //The players inventory
    DeathLog deathLog;                  //Reference to any killed enemies

    public string objText1;             //Objective text 1
    public string objText2;             //Objective text 2
    public string objText3;             //Objective text 3
    public string objText4;             //Objective text 4
    public string objText5;             //Objective text 5

    bool activeSound = false;           //Is a sound already playing

    public GameObject NPC;              //The NOC game object
    Animation anim;                     //Reference to the animation component

    public bool locked = false;         //Is the quest locked or not

    public bool dialogueOpen = false;   //Is the dialogue in the UI open
    public GameObject speakNotif;       //Notification for interaction

    bool speaking = false;              //Bool for active speaking
    bool removal = false;               //Bool for item removal


    //Initialises the references to scripts and components, and updates the quest details//
    void Start ()
    {
        playerStats = player.GetComponent<PlayerStats>();
        playerScript = player.GetComponent<playerController>();
        playerInventory = player.GetComponent<Inventory>();
        deathLog = player.GetComponent<DeathLog>();
        anim = NPC.GetComponent<Animation>();

        GetQuestDetails();
	}
	

    //Main update method for the class//
	void Update ()
    {
        //If the player is in range and Q is pressed, and is not speaking
        if (inRange == true && Input.GetKeyDown(KeyCode.Q) && speaking == false)
        {
            //Show the dialogue and hide the UI
            dialogueBox.SetActive(true);
            crosshair.SetActive(false);

            //Call the speak method and update the dialogue box text
            Speak();
            dialogueBoxText.text = currentDialogue;

            //Animation state change depending on ID
            if(ID == 1 || ID == 4 || ID == 5 || ID == 10 || ID == 13 || ID == 15)
            {
                anim.Play("sitting dialog");
            }
            else if(ID == 2)
            {
                anim.Play("dialog2");
            }
            else if (ID == 3 || ID == 12 || ID == 14)
            {
                anim.Play("dialog1");
            }
            else if (ID == 6 || ID == 7 || ID == 8 || ID == 9 || ID == 11)
            {
                anim.Play("dialog");
            }

            //Set booleans
            speaking = true;
            dialogueOpen = true;
        }

        //If the player is out of range and E is pressed
        if (inRange == true && Input.GetKeyDown(KeyCode.E))
        {
            //Show the dialogue and hide the UI
            dialogueBox.SetActive(false);
            crosshair.SetActive(true);

            //Animation state change depending on ID
            if (ID == 1 || ID == 4 || ID == 5 || ID == 10 || ID == 13 || ID == 15)
            {
                anim.Play("sitting idle");
            }
            else if (ID == 2)
            {
                anim.Play("blacksmith");
            }
            else if(ID == 3 || ID == 6 || ID == 7 || ID == 8 || ID == 9 || ID == 11 || ID == 12)
            {
                anim.Play("idle");
            }
            else if(ID == 14)
            {
                anim.Play("sweep");
            }

            //Set the booleans
            dialogueOpen = false;
        }
    }


    //This method generates the details of the quest based on its ID number//
    public void GetQuestDetails()
    {

        if(ID == 1)
        {
            title = "Lost in the Woods";
            person = "Bill Woodchuck";
            location = "";

            loot = 50;
            XP = 70;

            startDialogue = "Do you get into the forests much? I left my axe behind whilst working yesterday and I can't find it anywhere! It was left to me by my late grandfather and I'll pay a handsome reward fee to anyone who can bring it back.";
            activeDialogue = "Have you come across my axe yet? The area I was in when I was working is to the northwest of town, on the south side of the river. I'm not certain on this, but when I retrace my steps, I can picture a log cabin.";
            endDialogue = "Oh I am so pleased to see my favourite axe again! I was certain it was gone for good; things that get lost in those forests often are. Maybe next time I will pay more attention to where I leave my tools.";

            activeEntry = "The town lumberjack appears to have lost one of his axes in the woods somewhere. He said it was left to him by his late grandfather so it is imperative that he gets it back so he has put out a reward fee to anyone who can do so. When I spoke to him about where it was, he said it was to the northwest of town, on the south side of the river, possibly near a log cabin.";
            endEntry = "I found Bills axe towards the back of the log cabin in the middle of the woods. He was elated when I returned it and paid me 50 gold coins for the trouble. I think it was very special to him because of the sentimental value that it holds. I'm sure in the future he will be a bit more careful with it.";

            objText1 = "Lost Axe";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if(ID == 2)
        {
            title = "A Hilted Blade and a Leather Shield";
            person = "Sven Janesen";
            location = "";

            loot = 100;
            XP = 80;

            startDialogue = "Count Klarius has requested I smith a ceremonial sword and shield for his eldest sons birthday next week. I require boar pelt for the hilt on the sword and wolf pelt for the shield. Easy work for a hunter, if you want it?";
            activeDialogue = "Wild boars usually gather near parts of the river where they can get down to the water and they are fairly easy to hunt. Wolves you will find deeper in the forests. They are not so easy to hunt!";
            endDialogue = "Wonderful, I can see you took care when collecting the pelts, which is just what I needed. The Count paid me upfront so I'm happy to spend a bit more money on ensuring high quality. I will ask for you again when I need a hunter.";

            activeEntry = "Sven Jansen is the local smithy in the town and he has asked for a hunter to gather some materials. He requires a boar pelt for the hilt on a sword and a wolf pelt for the leather on a shield. The weapons he is crafting are ceremonial and intended for the Counts eldest sons birthday; it is important that the pelts are given to him in good condition.";
            endEntry = "I collected the pelts that Sven needed and was paid 100 coins for doing so. He is a very talented smithy and it will be interesting to see the final product. I'm sure the Count will be pleased with the sword and shield, as will his son.";

            objText1 = "Boar Pelt";
            objText2 = "Wolf Pelt";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 3)
        {
            title = "Goblins in the Hills";
            person = "Cpt. Marsh";
            location = "";

            loot = 500;
            XP = 150;

            startDialogue = "Fancy earning yourself 500 gold? My patrol guards have been having trouble recently with a nearby goblin encampment and the Count has put a price on the headpiece of the clans leader. They should be out in the hills, to the east of town.";
            activeDialogue = "Be careful if you do go out after those goblins, they are cunning fighters. They should be in the rocky hills, to the east of the town. Remember, if you can bring back the headpiece of the leader then the Count will pay 500 gold.";
            endDialogue = "I hope you got the bastard good! Those goblins have been making it hard to get supplies in and out of the town, causing the people and the Count great distress. Hopefully now that their leader is dead, they will begin to disperse.";

            activeEntry = "I spoke to the captain of the town guard and he said that a nearby goblin encampment had been causing him trouble. The Count has offered to pay 500 coins to anyone that can eliminate the goblin clan leader, bringing back its headpiece as proof. I was told that the camp was in the rocky hills, to the east of the town. This seems like it might be a difficult task to complete.";
            endEntry = "It wasn't easy but I managed to kill the goblin clan leader. I returned the headpiece to Captain Marsh and was paid the 500 coins promised. Carrying out bounty contracts seems like it good be a great way to make some money, even fi it is a little dangerous. ";

            objText1 = "Leaders Headpiece";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 4)
        {
            title = "Pest Control";
            person = "Peter Bosworth";
            location = "";

            loot = 100;
            XP = 80;

            startDialogue = "You any good with those weapons you carry around? Giant scorpions have been damaging my crops but they are too dangerous for me to kill. I can pay 100 coins if you help? They are to the north, directly behind the farm.";
            activeDialogue = "Did you see the scorpions? They are just behind the north-side fence of the farm. I tried to kill them myself but a pitchfork wasn't a good enough weapon. Make sure to watch out for their poisonous stingers.";
            endDialogue = "At last, the pests have been dealt with and I can harvest my crops in peace. They don't even eat them! They just rip apart the produce and ruin the soil looking for small rodents. Lets hope they don't come back.";

            activeEntry = "Peter Bosworth is a local farmer who tells me his crops have been ravaged by giant scorpions. He tried to deal with them himself, but he doesn't have the weapons or the ability. I can earn 100 coins if I deal with them for him. They should be behind the north-side fence of the farm.";
            endEntry = "I killed the scorpions that were damaging the farmers crops. The stingers have a venom in that I can extract to sell the local vendors if I need money. I think the area behind the farm is somewhere they are likely to keep turning up at.";

            objText1 = "Scorpion 1";
            objText2 = "Scorpion 2";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 5)
        {
            title = "The Mistrust of Brothers";
            person = "Adrian Satchi";
            location = "";

            loot = 300;
            XP = 130;

            startDialogue = "My brother set me up! He told me there was a treasure in the cave to the southeast of here, but there was just a big brown bear that mauled my leg! I will pay any man who can kill the beast.";
            activeDialogue = "I can't beleive my brother would set me up like that, I could of died! Why send me to a bears cave in search of some made-up treasure? Let me know when you have dealt with the animal and I can be happy.";
            endDialogue = "I feel much more at ease knowing the beast that damaged my leg has been put to rest. You must be a powerful warrior to have bested it! Now I just need to find my brother, you haven't seen him have you?";

            activeEntry = "Adrian Satchi thinks he has been set up by his brother. He was told to look in a nearby cave (to the southeast of the cabin) for treasure and was attacked by a bear whilst doing so. Adrian now wants the bear dead and will pay me if I can kill it. I wonder if there really is a treasure in that cave, or if his brother had truly tried to kill him.";
            endEntry = "I found the bears cave and killed it. He gave me 300 coins for dealing with the beast and then continued to rant about how angry he was with his brother. I wanted to tell him that there was a treasure in the cave, but then he might try to take it off me. I'm sure his brother will tell him the truth when they next meet.";

            objText1 = "Brown Bear";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 6)
        {
            title = "Misplaced Monkey";
            person = "Annabelle Oakley";
            location = "";

            loot = 0;
            XP = 100;

            startDialogue = "Waaaaaaaaaaa! I lost my favourite toy! I was out with my dad collecting ore at the bottom of the mountains and I must of left it behind! Please help me find my Mr.Monkey toy. It's too dangerous for me to go out on my own.";
            activeDialogue = "Have you seen my Mr.Monkey toy anywhere? I would ask my dad to find it but I think he will be mad at me for leaving it behind. We were collecting ore at the bottom of the mountains in the north when I last had it.";
            endDialogue = "Yayyy! Mr.Monkey is back! Thankyou ever so much! I thought he was going to be lost forever and I was so upset. I promise next time I am out of the town I will be more careful. Please don't tell my dad about this!";

            activeEntry = "Annabelle Oakley is a little girl that lives in the town. When I walked past her, she was crying her eyes out because she has lost her favourite soft toy. She thinks she left it somewhere near the bottom of the rocky mountains to the north of the town. No reward was mentioned, but I should have a look for her, she can't leave the town on her own and it's very dangerous out there.";
            endEntry = "I managed to find Mr.Monkey for little Annabelle and she was so happy to see her favourite toy again. I didn't get any reward for helping her out, but it made me feel nice to do soemthing good. Her crying was also very loud and annoying.";

            objText1 = "Lost Monkey Toy";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 7)
        {
            title = "Eye for an Eye";
            person = "Susan Satchi";
            location = "";

            loot = 200;
            XP = 140;

            startDialogue = "I am furious! A crocodile ate my pet dog! She was playing near the river behind the cabin and it snapped her up in one bite! I will pay 200 gold to whoever is capable of extracting justic for my little Coco.";
            activeDialogue = "My poor Coco! I loved that dog with all of my heart. Have you found the beast responsible yet? It should be lurking around in the nearby vicinity. Try looking behind the runestone, close to the river.";
            endDialogue = "An eye for an eye might make the whole world blind but right now its made me a lot happier! Nothing will replace my dog but at least its killer is dead and I can rest easy. Thankyou for bringing me some peace.";

            activeEntry = "I bumped into a woman who lives in a log cabin in the forests. She told me that a large river crocodile had recently eaten her pet dog. Understandbly, she is pretty angry about it and wants someone to kill the crocodile in revenge. It should be in the nearby area to the cabin and close to the rivers edge.";
            endEntry = "I killed the big crocodile that murdered the womans pet dog. She paid me 200 coins for doing the deed, and rightly so! That was one fearsome crocodile, the biggest I think I've ever seen in these parts.";

            objText1 = "Crocodile";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if(ID == 8)
        {
            title = "Brotherly Competition";
            person = "Julian Satchi";
            location = "";

            loot = 300;
            XP = 90;

            startDialogue = "You interested in making some real money? I know of an ancient relic, hidden within an old pagan ritual site. If you can bring it back to me, I'll split with you what I get on the market. Its rumoured to be made of solid gold.";
            activeDialogue = "The relic is in the ritual site, on the south side of the lake, in the eastern part of the forests. Be wary of the wolves that roam around there! I hear they have developed a hunger for human meat.";
            endDialogue = "Wow, it's even more magnificent than I thought it would be! I have a buyer lined up already, so selling it on won't be an issue. Usually I hunt treasure with my brother, but as he never shares the loot I've cut him out.";

            activeEntry = "I met one of the Satchi brothers in town and he told me about an ancient relic, hidden in an old pagan ritual site. If I can find it and bring it back to him he said he will split the money he gets on the market for it. The site is located on the south side of the lake, in the eastern part of the forests. Apprently it is infested with dangerous wolves.";
            endEntry = "I travelled to the ritual site and retrieved the relic for Julian. It sold for 600 coins so I was given 300 as my cut. He mentioned something about his brother not sharing the loot they find, and that being the reason why he cut him out and bought me in. A bit of brotherly arguing seems to have done me a favour.";

            objText1 = "Ancient Relic";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 9)
        {
            title = "Animal Vaccines";
            person = "Jack Jones";
            location = "";

            loot = 100;
            XP = 140;

            startDialogue = "Have you heard about the recent blight of mad cow disease? I know of a vaccine I can make to protect my livestock, but I need the ingridients. Scorpion venom, wild mushroom and hackleberry do should do the trick. If you can find them, I'll gladly pay.";
            activeDialogue = "Remember, if you wanted to help me make a vaccine for the animals I need; scorpion venom, wild mushroom and hackleberry. If I can't vaccinate my animals in time, I could lose an entire herd of cattle! Please don't let that happen.";
            endDialogue = "Ah perfect, you managed to get everything. I must make and adminster the vaccine straight away, before the disease spreads to this region. You have done me a great kindness, I hope your payment suffices.";

            activeEntry = "The livestock farmer in town is worried about a recent blight of mad cow disease spreading to the region and infecting his livestock. He offered me 100 coins if I can collect the ingridients he needs to make a vaccine for his animals. He asked for; scorpion venom, wild mushroom and hackleberry. I will have to explore the map well to find all three things he needs.";
            endEntry = "I found the three ingridients that Jack needed to create a vaccine for his livestock and he paid me 100 coins for helping him out. In fairness, I have done myself a favour. If Jack lost all of his cows then there would be no beef for me to buy at the market.";

            objText1 = "Scorpion Venom";
            objText2 = "Wild Mushroom";
            objText3 = "Hackleberry";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 10)
        {
            title = "Stones of the Stars";
            person = "Proffesor Graves";
            location = "";

            loot = 200;
            XP = 180;

            startDialogue = "Do you know of the ancient rune stones in these forests? It is said that they channel the energy of the stars to those who are near. I am looking for a researcher to note down the markings and bring them to me for further analysis; paid of course.";
            activeDialogue = "One stone lies to the south of the river and the other to the north. I have seen the southern stone before, but the northen one is in dangerous territory so I have yet to study it. Take care of yourself out in those forests.";
            endDialogue = "Hmmm, these are most interesting. It appears to be in a language earlier than anything I have seen before. I will have to study these sketches in more depth. You have done a good service to the sciences my friend.";

            activeEntry = "Proffesor Graves is a well known intellecutal in the local area, famous for her work in the field of astronomy. She says that in the forests are two ancient stones that channel the stars energy to those who go near them. She has asked me to find the stones and sketch down their markings so that she may learn more about their special powers. Her research is funded so she will pay me for the work.";
            endEntry = "I found both of the ancient stones and sketched down their markings for the Proffesor to study. I was paid 200 gold for helping her with her work and I'm interested to know what she finds out. I could certainly feel a power flowing through the stones and in to me when I was close to them.";

            objText1 = "Southern Stone";
            objText2 = "Northern Stone";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 11)
        {
            title = "Refreshing the Supplies";
            person = "Yanni Melkovich";
            location = "";

            loot = 100;
            XP = 75;

            startDialogue = "Do you get into town much? I really need a refresh of all of my supplies, but I don't have the time right now to get to market. I can give you the price of the goods and some extra if you can get them. I need; wolf pelt, boar meat and sweet pepper.";
            activeDialogue = "Have you managed to find the supplies I need yet? You can purchase them in the town or gather them from the forests. I need wolf pelt to make a coat and I need sweet pepper and boar meat to make a few days worth of tasty stew.";
            endDialogue = "Ah thats perfect, these supplies should keep me up here for a few more days till I can finish gathering this ore. I am most excited to replace my tattered coat with a wolf skin one, it gets awful cold up here. And lonley.";

            activeEntry = "Yanni Melkovich is a miner who spends most of his time up in the snowy mountains collecting ore. He told me that he is running low on supplies and he will pay someone to gather what he needs. The list he gave me was; wolf pelt, boar meat and sweet pepper. I can buy them in town, but it would be better if I gathered them from the forests myself.";
            endEntry = "I gathered the supplies that Yanni needed to keep himself up in the mountains for longer. I don't know how he does this job all the time. The conditions are harsh up here and there is no-one else to talk to!";

            objText1 = "Wolf Pelt";
            objText2 = "Boar Meat";
            objText3 = "Sweet Pepper";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 12)
        {
            title = "Guarding the Outposts";
            person = "Pvt. Stevens";
            location = "";

            loot = 200;
            XP = 120;

            startDialogue = "You ever tried mercenary work? Goblins have overrun the outpost that guards this path into the northern mountains and we are stretched too thin to take it back. If you think you can handle the task, get it done and report back to me.";
            activeDialogue = "Our last scouting mission reported that there were three goblin warriors holding the outpost. Follow this path to the northeast and you'll find where they are. There is a healthy sized bag of gold awaiting your success.";
            endDialogue = "Well done soldier, we should be able to move in within the hour and retake the outpost. It is a piviotal point in these parts and it guards the path into the mountains which many travellers and traders take.";

            activeEntry = "A soldier just outside of town has offered me some mercenary work. His outpost has been overrun by goblin warriors and he needs them dealt with. The outpost should be near the bottom of the northen mountains, if I follow the path on where I met the soldier. There are three to kill, and then I should report back to him immediately.";
            endEntry = "I made my way to the soldiers outpost and killed the three goblin warriors that were holed up there. Private Stevens says they intend to move in soon to reclaim the area. Apprently it is a key point in an important travel and trade route, perhaps the goblins knew that when they took it.";

            objText1 = "Goblin 1";
            objText2 = "Goblin 2";
            objText3 = "Goblin 3";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 13)
        {
            title = "Treasure in the Mountains";
            person = "Burt Banar";
            location = "";

            loot = 350;
            XP = 160;

            startDialogue = "Do you know the story of the Xenis brothers? They were an infamous pair of robbers who fled into the snowy mountains to bury their treasure. I think I know the location, if you have the strength and wits to retreive it.";
            activeDialogue = "The treasure should be somewhere in the abandoned outpost, on the east side of the mountains. Me and my companion came close to finding it, but we were attacked, costing him his life. Please help me make it worthwhile!";
            endDialogue = "My word! It's solid gold bars! I will be able to sell these for a small fortune in the city and make a lot of money for the both of us. I am glad that Arties death was not in vain. He will always be remembered.";

            activeEntry = "Burt Banar is a fellow adventurer and he told me about a treasure hidden in the snowy mountains. It is said the great robber Xenis brothers fled there, burying their loot for safekeeping. He thinks it is located in an abandoned outpost on the eastern side of the mountains. I should be careful, he said that his companion lost his life when they last tried to find it.";
            endEntry = "The treasure was hidden in the abandoned outpost, just as Burt said it would be. The area was crawling with goblin fighters, but it was worth it - the treasure was solid gold bars! Burt has given me 350 gold pieces now, and he will pay me more when he returns from the city after selling the bars. I hope it was worth the life that it cost his companion.";

            objText1 = "Treasure";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
        else if (ID == 14)
        {
            title = "Fixing up the Farm";
            person = "Patrick O'Neal";
            location = "";

            loot = 0;
            XP = 175;

            startDialogue = "Hey boss, we need a few things to get the farm in order if you can sort it out. We need corn to feed the animals, iron and stone for repairs, sweet pepper for the plantation and 300 gold for new chickens.";
            activeDialogue = "I know it seems like a lot, but if we get this place fixed up then you will make your money back on produce. The items that we need you to get for us are; corn, iron, stone, sweet pepper and 300 gold.";
            endDialogue = "That should be everything we need. Come back every so often to collect your produce and fill up the troughs with corn. Keep your animals happy and fed, and they will produce higher quality and quantity of goods to sell.";

            activeEntry = "It appears I have negelected my farm and the workers need a few things to get it in working order. They have asked for; corn to feed the animals, iron and stone to make repairs to the buildings, sweet peppers to start a plantation and 300 gold so they may get new chickens in. If i can get it working again, it will regularly create produce for me to sell at the markets.";
            endEntry = "Patrick, the main farmhand, has used the things I provided to get the farm fixed up. Sweet peppers now grow in the plantation, chickens lay eggs for me to collect and the cows produce milk. To keep everything going I need to remember to keep the troughs filled up with corn. If my animals get hungry, they won't be able to make produce.";

            objText1 = "Corn";
            objText2 = "Iron";
            objText3 = "Stone";
            objText4 = "Sweet Pepper";
            objText5 = "300 Gold";
        }
        else if (ID == 15)
        {
            title = "Loud Conversations";
            person = "Little Marsh";
            location = "";

            loot = 0;
            XP = 120;

            startDialogue = "Do you like stories? My dad is captain of the guard and I hear him tell stories. Last night he was telling one to the other soldiers about a powerful sword hidden in a cave. He said it held great power.";
            activeDialogue = "Did you find out if the story was true? Apparently the sword belonged to a great general who used to protect these lands. If you do find it, please show me! I promise I won't tell my dad that you have it.";
            endDialogue = "That is one sharp sword! I thought all of my dads stories were make-beleive, but this one obviously isn't. I wish I knew more about the great general it belonged to. What happened to him? How did he lose it?";

            activeEntry = "The son of the captain of the guard overrheard his dad discussing a powerful sword they intended to retreive. Apparently it is located in a cave, somewhere along the bottom of the snowy mountains in the north. It is said that it belonged to a great general, famous in the local area. Maybe I should try and find it, it might be valuable.";
            endEntry = "The great generals sword was in the cave, just like the boy said it was. It's still in good condition so it could be used. I wonder if the soldiers will go there to look for it? They will not be happy when they find out it isn't there. Although they will have no idea it was me.";

            objText1 = "Sword";
            objText2 = "";
            objText3 = "";
            objText4 = "";
            objText5 = "";
        }
    }


    //This method updates the state of the quest and its components//
    public void Speak()
    {
        //When this is first called, set the quest to started
        questStarted = true;

        //If the quest has just been started
        if (questStarted == true && questActive == false && questEnded == false)
        {
            //Update the dialogue and log entry
            currentDialogue = startDialogue;
            logEntry = activeEntry;

            //Update the quest state text
            questStateText.text = title + "  ---  QUEST STARTED";

            //If a sound is not already playing, play a new one
            if(activeSound == false)
            {
                startQuestSound.Play();
                activeSound = true;
                StartCoroutine(DelayQSound());
            }
        }

        //If the quest is active
        if (questStarted == true && questActive == true && questEnded == false)
        {
            //Update the dialogue and state text
            currentDialogue = activeDialogue;
            questStateText.text = title + "  ---  QUEST ACTIVE";

            //Check for reward conditions
            CheckReward();
        }

        //If the quest has ended
        if (questStarted == true && questActive == true && questEnded == true)
        {
            //Update the dialogue
            currentDialogue = endDialogue;

            //Reward the player
            Reward();

            //Update the log entry and quest state
            logEntry = endEntry;
            questStateText.text = title + "  ---  QUEST FINISHED";
        }
    }


    //This method delays the quest sounds//
    IEnumerator DelayQSound()
    {
        yield return new WaitForSeconds(10);
        activeSound = false;
    }


    //This method rewards the player with money and XP, plays the end of quest sound and removes the quest items//
    public void Reward()
    {
        //If the quest is not finished yet
        if (finished == false)
        {
            //If the quest has a financial reward, add the gold
            if (ID == 1 || ID == 2 || ID == 3 || ID == 4 || ID == 5 || ID == 7 || ID == 8 || ID == 9 || ID == 10 || ID == 11 || ID == 12 || ID == 13)
            {
                //Add coins to the players coins
                playerScript.AddGold(loot);
            }

            //Add XP to the players XP
            playerStats.AddXP(XP);

            //If the level up sound is not playing, play the end quest sound
            if (playerStats.levelled == false)
            {
                endQuestSound.Play();
            }

            //Remove the items from the player, depending on ID
            if(ID == 1)
            {
                playerInventory.RemoveItem(101);
            }
            else if(ID == 2)
            {
                playerInventory.RemoveItem(103);
                playerInventory.RemoveItem(112);
            }
            else if (ID == 3)
            {
                playerInventory.RemoveItem(109);
            }
            else if (ID == 6)
            {
                playerInventory.RemoveItem(107);
            }
            else if (ID == 8)
            {
                playerInventory.RemoveItem(111);
            }
            else if (ID == 9)
            {
                playerInventory.RemoveItem(105);
                playerInventory.RemoveItem(110);
                playerInventory.RemoveItem(120);
            }
            else if (ID == 10)
            {
                playerInventory.RemoveItem(113);
                playerInventory.RemoveItem(114);
            }
            else if (ID == 11)
            {
                playerInventory.RemoveItem(112);
                playerInventory.RemoveItem(102);
                playerInventory.RemoveItem(104);
            }
            else if (ID == 13)
            {
                playerInventory.RemoveItem(115);
            }
            else if (ID == 14)
            {
                playerInventory.RemoveItem(116);
                playerInventory.RemoveItem(117);
                playerInventory.RemoveItem(118);
                playerInventory.RemoveItem(104);
                playerScript.Count -= 300;
            }

            //Set the quest as finished
            finished = true;
        }
    }


    //This method checks the reward requirements depending on ID//
    public void CheckReward()
    {
        if (ID == 1)
        {
            //Check for the item
            playerInventory.CheckForItem(101);

            //End the quest if item is owned
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }
        }
        else if (ID == 2)
        {
            //Booleans for the items
            bool boarP = false;
            bool wolfP = false;

            //Check for item 1
            playerInventory.CheckForItem(103);
            boarP = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for item 2
            playerInventory.CheckForItem(112);
            wolfP = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //If the items are owned, end the quest
            if (boarP == true && wolfP == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 3)
        {
            //Check for the item
            playerInventory.CheckForItem(109);

            //If the item is owned, end the quest
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }
        }
        else if (ID == 4)
        {
            //If the enemies are dead, end the quest
            if (deathLog.scorpion1dead == true && deathLog.scorpion2dead == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 5)
        {
            //If the enemy is dead, end the quest
            if (deathLog.bearDead == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 6)
        {
            //Check for the item
            playerInventory.CheckForItem(107);

            //If the item is owned, end the quest
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }
        }
        else if (ID == 7)
        {
            //If the enemy is dead, end the quest
            if (deathLog.crocodileDead == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 8)
        {
            //Check for the item
            playerInventory.CheckForItem(111);

            //If the item is owned, end the quest
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }
        }
        else if (ID == 9)
        {
            //Booleans for the items
            bool venom = false;
            bool mushroom = false;
            bool berries = false;

            //Check for the item
            playerInventory.CheckForItem(105);
            venom = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(110);
            mushroom = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(120);
            berries = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //If the items are owned, end the quest
            if (venom == true && mushroom == true && berries == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 10)
        {
            //Booleans for the items
            bool south = false;
            bool north = false;

            //Check for the item
            playerInventory.CheckForItem(113);
            south = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(114);
            north = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //If the items are owned, end the quest
            if (south == true && north == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 11)
        {
            //Booleans for the items
            bool wolf = false;
            bool boar = false;
            bool pepper = false;

            //Check for the item
            playerInventory.CheckForItem(112);
            wolf = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(102);
            boar = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(104);
            pepper = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //If the items are owned, end the quest
            if (wolf == true && boar == true && pepper == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 12)
        {
            //If the enemies are dead, end the quest
            if (deathLog.goblin4dead == true && deathLog.goblin5dead == true && deathLog.goblin6dead == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 13)
        {
            //Check for the item
            playerInventory.CheckForItem(115);

            //If the item is owned, end the quest
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }
        }
        else if (ID == 14)
        {
            //Booleans for the items and gold
            bool corn = false;
            bool iron = false;
            bool stone = false;
            bool pepper = false;
            bool gold = false;

            //Check for the item
            playerInventory.CheckForItem(116);
            corn = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(117);
            iron = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(118);
            stone = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //Check for the item
            playerInventory.CheckForItem(104);
            pepper = playerInventory.OwnedItem;
            playerInventory.OwnedItem = false;

            //If the player has 300 gold, set bool as true
            if (playerScript.Count >= 300)
            {
                gold = true;
            }

            //If the items and gold are owned, end the quest
            if (corn == true && iron == true && stone == true && pepper == true && gold == true)
            {
                questEnded = true;
            }
        }
        else if (ID == 15)
        {
            //Check for the item
            playerInventory.CheckForItem(306);

            //If the item is owned end the quest
            if (playerInventory.OwnedItem == true)
            {
                questEnded = true;
                playerInventory.OwnedItem = false;
            }

            //If the item is equipped, end the quest
            if(playerScript.activeWeapon.matchingItem.title == "Arnars Might" || playerScript.unactiveWeapon.matchingItem.title == "Arnars Might")
            {
                questEnded = true;
            }
        }

    }


    //Whether the player is in speaking range//
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Set as in range and show notification
            inRange = true;
            speakNotif.SetActive(true);
        }
    }


    //If the player has left speaking range//
    public void OnTriggerExit(Collider other)
    {
        //Set as out of range, hide notification, set as not speaking
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            speakNotif.SetActive(false);
            speaking = false;
        }

        //Set the quest as active if it has just been started
        if (other.gameObject.CompareTag("Player") && questStarted == true)
        {
            questActive = true;
        }
    }
}
