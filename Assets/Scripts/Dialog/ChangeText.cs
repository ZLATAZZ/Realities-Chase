using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ChangeText : MonoBehaviour
{
    private string btnName;
    [Header("Canvas")]
    public TMP_Text newMessage;
    public Image dialogWindow;
    [Header("Necessary buttons")]
    public Button btnClose;
    public Button btnCloseB;
    public Button btnCloseBFinal;
    public Button btnGooseStart;
    public Button btnGooseFinal;
    public Button btnFrogFinal;
   

    public Image Control;


    [Header("When we move")]
    [SerializeField]
    private GameObject detectMove;

    [Header("Choose the Helper")]
    [SerializeField]
    private bool isMushroom;
    [SerializeField]
    private bool isWatcher;
    [SerializeField]
    private bool isFairyFinal;
    [SerializeField]
    private bool isIsland;

    //Colourful citations
    private static string playerName = "<color=purple>Player:</color>";
    private static string fairyName = "<color=#fc03ca>Fairy:</color>";
    private static string mushroomName = "<color=#1000eb>Mushroom:</color>";
    private static string frogName = "<color=green>Frog:</color>";
    private static string birdName = "<color=red>Bird:</color>";
    private static string gooseName = "<color=orange>Goose:</color>";


    //variables from other classes
    PlayerControllerIslands movingController;
    PlayerController movingController2;
    BirdDetect1 isBird1;
    PutJeweleries isBirdLast;
    GooseControlStart isGooseControlStart;
    FinalDialogGoose isGooseLast;
    LastDetect isFrogLast;

    [Header("Creature Objects")]
    [SerializeField]
    GameObject creature;
    [SerializeField]
    GameObject frog;
   

    
    //booleans for creatures talk
    private bool is0, is1, is2, is3, is4, is5, is6, is7, is8, is9, is10, is11, is12, is13, is14, is15, is16, is17,
        is18, is19, is20, is21, is22, is23, is24, is25, is26, is27, is28, is29, is30 = false;

    //booleans for player talk
    private bool player0, player1, player2, player3, player4, player5, player6, player7, player8, player9, player10,
        player11, player12, player13, player14, player15, player16, player17, player18, player19, player20, player21, player22,
        player23, player24, player25, player26, player27, player28, player29, player30 = false;

    private bool isFrog = true;



    private void Start()
    {

        if (isWatcher)
        {
            movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
            movingController.isMoving = false;
            dialogWindow.gameObject.SetActive(true);
            newMessage.SetText("...");

            player0 = true;

        }

        else if (isMushroom)
        {
            player0 = true;
            movingController2 = GameObject.FindObjectOfType<PlayerController>();
            dialogWindow.gameObject.SetActive(true);
            movingController2.isMoving = false;

            newMessage.SetText("...");
            newMessage.fontSize = 0.07f;
        }

        else if (isFairyFinal)
        {
            movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
            movingController.isMoving = false;
            newMessage.SetText("...");
            player0 = true;
            newMessage.fontSize = 0.07f;
        }

        else if (isIsland)
        {
            movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
            movingController.isMoving = false;
            newMessage.SetText("...");
            player0 = true;
            newMessage.fontSize = 0.07f;
            isBird1 = GameObject.FindObjectOfType<BirdDetect1>();
            isBirdLast = GameObject.FindObjectOfType<PutJeweleries>();
            isGooseControlStart = GameObject.FindObjectOfType<GooseControlStart>();
            isGooseLast = GameObject.FindObjectOfType<FinalDialogGoose>();
            isFrogLast = GameObject.FindObjectOfType<LastDetect>();

        }


    }
    private void Update()
    {
        //add it to PlayerTalk, after last playertalk
        PlayerTalk();
        ChangeTextOnSpace();

        if (detectMove.activeSelf)
        {
            if (isMushroom)
            {
                movingController2.isMoving = true;
                
                creature.SetActive(false);
            }
            else if (isIsland)
            {
                movingController.isMoving = true;
                newMessage.text = string.Empty;
                
                is0 = true;
                isFrog = false;
                isBird1.isBird1Start = false;
                isBirdLast.isBirdFinal = false;
                isGooseControlStart.isGoose = false;
                creature.SetActive(false);
                frog.SetActive(true);
                isBirdLast.isBirdFinal = false;
                isGooseLast.isGooseFinal = false;
                isFrogLast.isFrogFinal = false;


            }
            else if (isWatcher || isFairyFinal)
            {
                movingController.isMoving = true;
                newMessage.text = string.Empty;
                creature.SetActive(false);
            }


        }
        
       
    }




    //Player talk to himself
    void PlayerTalk()
    {
        //For Watcher
        if (isWatcher)
        {
            if (Input.GetKeyDown(KeyCode.Space) && player0)
            {

                newMessage.SetText($"{playerName} What the frick? Where am I?");
                newMessage.fontSize = 0.07f;
                player0 = false;
                player1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player1)
            {
                newMessage.SetText($"{playerName} Ohhh. My head is killing me. I can't recall anything.");
                newMessage.fontSize = 0.07f;
                player1 = false;
                player2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player2)
            {
                newMessage.SetText($"{playerName} What happened? How did I get here?");
                newMessage.fontSize = 0.07f;
                player2 = false;
                player3 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player3)
            {
                newMessage.SetText($"{playerName} What the hell is going on?");
                newMessage.fontSize = 0.07f;
                player3 = false;
                player4 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player4)
            {
                newMessage.SetText($"{playerName} What the f.…. Who are you?");
                newMessage.fontSize = 0.07f;
                player4 = false;
                player5 = true;
                creature.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player5)
            {
                newMessage.SetText($"{playerName} Hey! What is going on here?");
                newMessage.fontSize = 0.07f;
                player5 = false;
                is0 = true;


            }

        }

        //For Mushroom
        if (isMushroom)
        {
            if (Input.GetKeyDown(KeyCode.Space) && player0)
            {

                newMessage.SetText($"{fairyName} This is the first helper!");
                newMessage.fontSize = 55.0f;
                player0 = false;
                player1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player1)
            {
                newMessage.SetText($"{fairyName} His language is very poetic, and sometimes strange. You'll see...");
                newMessage.fontSize = 55.0f;
                player1 = false;
                player2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player2)
            {
                newMessage.SetText($"{fairyName} Listen to him carefully, it does not talk twice!!! ");
                newMessage.fontSize = 55.0f;
                player2 = false;
                player3 = true;
              
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player3)
            {
                newMessage.SetText($"{fairyName} Listen to him carefully, they do not talk twice!!! ");
                newMessage.fontSize = 55.0f;
                player3 = false;

                is0 = true;
            }
        }

        //For Final
        if (isFairyFinal)
        {
            if (Input.GetKeyDown(KeyCode.Space) && player0)
            {

                newMessage.SetText($"{fairyName} Oh, dude, you succeed with coming to an end");
                newMessage.fontSize = 55.0f;
                player0 = false;
                player1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player1)
            {
                newMessage.SetText($"{fairyName} Not all of them could do this hehe");
                newMessage.fontSize = 55.0f;
                player1 = false;
                player2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player2)
            {
                newMessage.SetText($"{playerName} Who is ‘them’?");
                newMessage.fontSize = 55.0f;
                player2 = false;
                player3 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player3)
            {
                newMessage.SetText($"{fairyName} Oh, never mind");
                newMessage.fontSize = 55.0f;
                player3 = false;
                player4 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player4)
            {
                newMessage.SetText($"{playerName} So, the last step is to choose right path");
                newMessage.fontSize = 55.0f;
                player4 = false;
                player5 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player5)
            {
                newMessage.SetText($"{playerName} ?");
                newMessage.fontSize = 55.0f;
                player5 = false;
                player6 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player6)
            {
                newMessage.SetText($"{fairyName} Right portal, if to be clear");
                newMessage.fontSize = 55.0f;
                player6 = false;
                player7 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player7)
            {
                newMessage.SetText($"{playerName} Right portal? I thought that your FRICK challenges come to an end!!!");
                newMessage.fontSize = 55.0f;
                player7 = false;
                player8 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player8)
            {
                newMessage.SetText($"{fairyName} Hehe, almost all of them");
                newMessage.fontSize = 55.0f;
                player8 = false;
                player9 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player9)
            {
                newMessage.SetText($"{playerName} Ohhh, okay, then explain me what you mean");
                newMessage.fontSize = 55.0f;
                player9 = false;
                player10 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player10)
            {
                newMessage.SetText($"{fairyName} Sure! Right portal will lead to the desire destination….hopefully");
                newMessage.fontSize = 55.0f;
                player10 = false;
                player11 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player11)
            {
                newMessage.SetText($"{fairyName} The wrong one to the struggling");
                newMessage.fontSize = 55.0f;
                player11 = false;
                player12 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player12)
            {
                newMessage.SetText($"{playerName} …");
                newMessage.fontSize = 55.0f;
                player12 = false;
                player13 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player13)
            {
                newMessage.SetText($"{fairyName} I can’t tell you what the struggling is exactly");
                newMessage.fontSize = 55.0f;
                player13 = false;
                player14 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player14)
            {
                newMessage.SetText($"{fairyName} You’ll know it");
                newMessage.fontSize = 55.0f;
                player14 = false;
                player15 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player15)
            {
                newMessage.SetText($"{fairyName} Or not");
                newMessage.fontSize = 55.0f;
                player15 = false;
                player16 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player16)
            {
                newMessage.SetText($"{playerName} Shit…");
                newMessage.fontSize = 55.0f;
                player16 = false;
                player17 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player17)
            {
                newMessage.SetText($"{fairyName} Huh?");
                newMessage.fontSize = 55.0f;
                player17 = false;
                player18 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player18)
            {
                newMessage.SetText($"{playerName} Nothing…");
                newMessage.fontSize = 55.0f;
                player18 = false;
                player19 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player19)
            {
                newMessage.SetText($"{playerName} Anyway, any hints how to choose?");
                newMessage.fontSize = 55.0f;
                player19 = false;
                player20 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player20)
            {
                newMessage.SetText($"{fairyName} Oh, yeah!");
                newMessage.fontSize = 55.0f;
                player20 = false;
                player21 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player21)
            {
                newMessage.SetText($"{fairyName} Just trust your heart hehe");
                newMessage.fontSize = 55.0f;
                player21 = false;
                player22 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player22)
            {
                newMessage.SetText($"{playerName} Are you kidding me?");
                newMessage.fontSize = 55.0f;
                player22 = false;
                player23 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player23)
            {
                newMessage.SetText($"{fairyName} Never");
                newMessage.fontSize = 55.0f;
                player23 = false;
                player24 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player24)
            {
                newMessage.SetText($"{playerName} ...");
                newMessage.fontSize = 55.0f;
                player24 = false;
                player25 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player25)
            {
                newMessage.SetText($"{fairyName} All right, dude, I have no more time for you. Good luck!");
                newMessage.fontSize = 55.0f;
                player25 = false;
                player26 = true;
                

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player26)
            {
                newMessage.SetText($"{fairyName} Good luck!");
                newMessage.fontSize = 55.0f;
                player26 = false;
                creature.SetActive(false);
                is0 = true;
            }
        }

        //For Island
        if(isIsland)
        {
            if (isFrog)
            {
                if (Input.GetKeyDown(KeyCode.Space) && player0)
                {

                    newMessage.SetText($"{fairyName} Good job! You've even escaped...hehe");
                    newMessage.fontSize = 55.0f;
                    player0 = false;
                    player1 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && player1)
                {
                    newMessage.SetText($"{fairyName} Keep going, dude...");
                    newMessage.fontSize = 55.0f;
                    player1 = false;
                    player2 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player2)
                {
                    newMessage.SetText($"{playerName} Oh, annoying fairy");
                    newMessage.fontSize = 55.0f;
                    player2 = false;
                    player3 = true;
                    creature.SetActive(false);
                }
                else if (Input.GetKeyDown(KeyCode.Space) && player3)
                {
                    newMessage.SetText($"{playerName} Oh, well, at first was the talking mushroom, now it is a frog");
                    newMessage.fontSize = 55.0f;
                    player3 = false;
                    player4 = true;
                    frog.SetActive(true);

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player4)
                {
                    newMessage.SetText($"{playerName} Awesome");
                    newMessage.fontSize = 55.0f;
                    player4 = false;
                    player5 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player5)
                {
                    newMessage.SetText($"{frogName} Hello my dear friend, ribbit-ribbit!");
                    newMessage.fontSize = 55.0f;
                    player5 = false;
                    player6 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player6)
                {
                    newMessage.SetText($"{frogName} Are you still here?");
                    newMessage.fontSize = 55.0f;
                    player6 = false;
                    player7 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player7)
                {
                    newMessage.SetText($"{playerName} ?");
                    newMessage.fontSize = 55.0f;
                    player7 = false;
                    player8 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player8)
                {
                    newMessage.SetText($"{frogName} ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    player8 = false;
                    player9 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player9)
                {
                    newMessage.SetText($"{frogName} Never mind");
                    newMessage.fontSize = 55.0f;
                    player9 = false;
                    player10 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player10)
                {
                    newMessage.SetText($"{playerName} <i>(why are they all so strange, I need to get out of here)</i> So, how can I leave this place?");
                    newMessage.fontSize = 55.0f;
                    player10 = false;
                    player11 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player11)
                {
                    newMessage.SetText($"{frogName} It's the same as the last time");
                    newMessage.fontSize = 55.0f;
                    player11 = false;
                    player12 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player12)
                {
                    newMessage.SetText($"{frogName} Don't you remember?");
                    newMessage.fontSize = 55.0f;
                    player12 = false;
                    player13 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player13)
                {
                    newMessage.SetText($"{playerName} Emm, No.");
                    newMessage.fontSize = 55.0f;
                    player13 = false;
                    player14 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player14)
                {
                    newMessage.SetText($"{playerName} This is my first time here");
                    newMessage.fontSize = 55.0f;
                    player14 = false;
                    player15 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player15)
                {
                    newMessage.SetText($"{frogName} Okay. I’ll be brief");
                    newMessage.fontSize = 55.0f;
                    player15 = false;
                    player16 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player16)
                {
                    newMessage.SetText($"{frogName} I will open the way for you further if you help my friends");
                    newMessage.fontSize = 55.0f;
                    player16 = false;
                    player17 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player17)
                {
                    newMessage.SetText($"{frogName} Is it clear? ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    player17 = false;
                    player18 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player18)
                {
                    newMessage.SetText($"{playerName} I think so");
                    newMessage.fontSize = 55.0f;
                    player18 = false;
                    player19 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player19)
                {
                    newMessage.SetText($"{playerName} Where can I find them?");
                    newMessage.fontSize = 55.0f;
                    player19 = false;
                    player20 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player20)
                {
                    newMessage.SetText($"{frogName} They are on their islands");
                    newMessage.fontSize = 55.0f;
                    player20 = false;
                    player21 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player21)
                {
                    newMessage.SetText($"{frogName} You won’t miss them");
                    newMessage.fontSize = 55.0f;
                    player21 = false;
                    player22 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player22)
                {
                    newMessage.SetText($"{frogName} So, go ahead and don’t forget to come back to me. Good luck! ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    player22 = false;
                    player23 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && player23)
                {
                    newMessage.SetText($"{playerName} Fine");
                    newMessage.fontSize = 55.0f;
                    player23 = false;
                    player24 = true;
                    btnClose.gameObject.SetActive(true);
                    is0 = true;

                }

            }
           
            //talk with bird
            if (isBird1.isBird1Start)
            {
                //Control.gameObject.SetActive(true);
                dialogWindow.gameObject.SetActive(true);
                btnClose.gameObject.SetActive(false);
                btnCloseB.gameObject.SetActive(true);
                btnCloseBFinal.gameObject.SetActive(false);
                btnGooseStart.gameObject.SetActive(false);

                if (Input.GetKeyDown(KeyCode.Space) && is0)
                {
                    newMessage.SetText($"{playerName} Hey, as I understand you’re one of the Frog’s friend");
                    newMessage.fontSize = 55.0f;
                    is0 = false;
                    is1 = true;
                    btnCloseB.gameObject.SetActive(true);
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is1)
                {

                    newMessage.SetText($"{birdName} Oh, yeah, you’re right");
                    newMessage.fontSize = 55.0f;
                    is1 = false;
                    is2 = true;
                    
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is2)
                {

                    newMessage.SetText($"{birdName} As you know I got in trouble…");
                    newMessage.fontSize = 55.0f;
                    is2 = false;
                    is3 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is3)
                {

                    newMessage.SetText($"{birdName} I lost my confidence");
                    newMessage.fontSize = 55.0f;
                    is3 = false;
                    is4 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is4)
                {

                    newMessage.SetText($"{playerName} Wait! What?");
                    newMessage.fontSize = 55.0f;
                    is4 = false;
                    is5 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is5)
                {

                    newMessage.SetText($"{birdName} I’m not beautiful anymore!!!!");
                    newMessage.fontSize = 55.0f;
                    is5 = false;
                    is6 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is6)
                {

                    newMessage.SetText($"{birdName} I lost my jewelleries in this maze");
                    newMessage.fontSize = 55.0f;
                    is6 = false;
                    is7 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is7)
                {

                    newMessage.SetText($"{birdName} And now I feel insecure!");
                    newMessage.fontSize = 55.0f;
                    is7 = false;
                    is8 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is8)
                {
                    
                    newMessage.SetText($"{playerName} All right, all right");
                    newMessage.fontSize = 55.0f;
                    is8 = false;
                    is9 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is9)
                {
                    
                    newMessage.SetText($"{playerName} Do you want me to find them?");
                    newMessage.fontSize = 55.0f;
                    is9 = false;
                    is10 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is10)
                {
                   
                    newMessage.SetText($"{birdName} Oh, that would me very nice, thank you!");
                    newMessage.fontSize = 55.0f;
                    is10 = false;
                    is11 = true;
                }
            }

            if(isBirdLast.isBirdFinal)
            {

                //Control.gameObject.SetActive(true);
                dialogWindow.gameObject.SetActive(true);
                //detectMove.SetActive(false);
                btnClose.gameObject.SetActive(false);
                btnCloseB.gameObject.SetActive(false);
                btnCloseBFinal.gameObject.SetActive(true);
                btnGooseStart.gameObject.SetActive(false);

                if (Input.GetKeyDown(KeyCode.Space) && is0)
                {
                    newMessage.SetText($"{birdName} OMG, I’m the most stunning girl in the world!");
                    newMessage.fontSize = 55.0f;
                    is0 = false;
                    is1 = true;
                    
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is1)
                {
                    newMessage.SetText($"{playerName} Bird, actually…");
                    newMessage.fontSize = 55.0f;
                    is1 = false;
                    is2 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is2)
                {

                    newMessage.SetText($"{birdName} What?");
                    newMessage.fontSize = 55.0f;
                    is2 = false;
                    is3 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is3)
                {

                    newMessage.SetText($"{playerName} Nothing, just let Frog know that I helped you");
                    newMessage.fontSize = 55.0f;
                    is3 = false;
                    is4 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is4)
                {

                    newMessage.SetText($"{birdName} Yes, sure, I’ll tell her, thank you once more! ");
                    newMessage.fontSize = 55.0f;
                    is4 = false;
                    is5 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is5)
                {

                    newMessage.SetText($"{playerName} No worries");
                    newMessage.fontSize = 55.0f;
                    is5 = false;
                    is6 = true;
                    
                }
               
            }

            if (isGooseControlStart.isGoose)
            {
                Control.gameObject.SetActive(true);
                dialogWindow.gameObject.SetActive(true);
                btnClose.gameObject.SetActive(false);
                btnCloseB.gameObject.SetActive(false);
                btnCloseBFinal.gameObject.SetActive(false);
                btnGooseStart.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Space) && is0)
                {

                    newMessage.SetText($"{playerName} Oh, well, another bird with its problem");
                    newMessage.fontSize = 55.0f;
                    is0 = false;
                    is1 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is1)
                {
                    newMessage.SetText($"{playerName} So, alright, what’s happened with you?");
                    newMessage.fontSize = 55.0f;
                    is1 = false;
                    is2 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is2)
                {

                    newMessage.SetText($"{gooseName} My flowers of life have disappeared");
                    newMessage.fontSize = 55.0f;
                    is2 = false;
                    is3 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is3)
                {

                    newMessage.SetText($"{playerName} What?");
                    newMessage.fontSize = 55.0f;
                    is3 = false;
                    is4 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is4)
                {

                    newMessage.SetText($"{gooseName} My bambino blooms left me!");
                    newMessage.fontSize = 55.0f;
                    is4 = false;
                    is5 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is5)
                {

                    newMessage.SetText($"{playerName} What the sh… are you talking about");
                    newMessage.fontSize = 55.0f;
                    is5 = false;
                    is6 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is6)
                {

                    newMessage.SetText($"{playerName} Stop talking with weird words");
                    newMessage.fontSize = 55.0f;
                    is6 = false;
                    is7 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is7)
                {

                    newMessage.SetText($"{playerName} Adequately, explain what is going on");
                    newMessage.fontSize = 55.0f;
                    is7 = false;
                    is8 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is8)
                {

                    newMessage.SetText($"{gooseName} My mini copies");
                    newMessage.fontSize = 55.0f;
                    is8 = false;
                    is9 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is9)
                {

                    newMessage.SetText($"{playerName} ...");
                    newMessage.fontSize = 55.0f;
                    is9 = false;
                    is10 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is10)
                {

                    newMessage.SetText($"{gooseName}  Oh, my children has disappeared. I can’t find them!!!!");
                    newMessage.fontSize = 55.0f;
                    is10 = false;
                    is11 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is11)
                {

                    newMessage.SetText($"{playerName}  Really? How you lost them on YOUR island.");
                    newMessage.fontSize = 55.0f;
                    is11 = false;
                    is12 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is12)
                {

                    newMessage.SetText($"{gooseName} They just played hide-and-seek...please, help me");
                    newMessage.fontSize = 55.0f;
                    is12 = false;
                    is13 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is13)
                {

                    newMessage.SetText($"{playerName} All right, how many of them?");
                    newMessage.fontSize = 55.0f;
                    is13 = false;
                    is14 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is14)
                {

                    newMessage.SetText($"{gooseName} Just 3 kids");
                    newMessage.fontSize = 55.0f;
                    is14 = false;
                    is15 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is15)
                {

                    newMessage.SetText($"{playerName} Okay, I’ll find them");
                    newMessage.fontSize = 55.0f;
                    is15 = false;
                    is16 = true;
                }


            }

            if(isGooseLast.isGooseFinal)
            {
                Control.gameObject.SetActive(true);
                dialogWindow.gameObject.SetActive(true);
                btnClose.gameObject.SetActive(false);
                btnCloseB.gameObject.SetActive(false);
                btnCloseBFinal.gameObject.SetActive(false);
                btnGooseStart.gameObject.SetActive(false);
                btnGooseFinal.gameObject.SetActive(true);
                isGooseLast.goosesStart.SetActive(false);
                

                if (Input.GetKeyDown(KeyCode.Space) && is0)
                {

                    newMessage.SetText($"{playerName} So, here they are");
                    newMessage.fontSize = 55.0f;
                    is0 = false;
                    is1 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is1)
                {
                    newMessage.SetText($"{gooseName} Thank you so much!");
                    newMessage.fontSize = 55.0f;
                    is1 = false;
                    is2 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is2)
                {

                    newMessage.SetText($"{gooseName} My life is blooming again!");
                    newMessage.fontSize = 55.0f;
                    is2 = false;
                    is3 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is3)
                {

                    newMessage.SetText($"{playerName} I’m so happy for you, but just tell Frog, that I helped you");
                    newMessage.fontSize = 55.0f;
                    is3 = false;
                    is4 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is4)
                {

                    newMessage.SetText($"{gooseName} Oh, yeah, yeah, sure");
                    newMessage.fontSize = 55.0f;
                    is4 = false;
                    is5 = true;
                }
                
            }

            if(isFrogLast.isFrogFinal)
            {
                Control.gameObject.SetActive(true);
                dialogWindow.gameObject.SetActive(true);
                btnClose.gameObject.SetActive(false);
                btnCloseB.gameObject.SetActive(false);
                btnCloseBFinal.gameObject.SetActive(false);
                btnGooseStart.gameObject.SetActive(false);
                btnGooseFinal.gameObject.SetActive(false);
                btnFrogFinal.gameObject.SetActive(true); 
                
                if (Input.GetKeyDown(KeyCode.Space) && is0)
                {

                    newMessage.SetText($"{frogName} My dear friend, are you back?");
                    newMessage.fontSize = 55.0f;
                    is0 = false;
                    is1 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is1)
                {
                    newMessage.SetText($"{frogName} ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    is1 = false;
                    is2 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is2)
                {

                    newMessage.SetText($"{frogName} Did you do as I asked?");
                    newMessage.fontSize = 55.0f;
                    is2 = false;
                    is3 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is3)
                {

                    newMessage.SetText($"{playerName} Yes. Can I get out of here now?");
                    newMessage.fontSize = 55.0f;
                    is3 = false;
                    is4 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is4)
                {

                    newMessage.SetText($"{frogName} Of course. You’ve probably already noticed a portal at the top of this island");
                    newMessage.fontSize = 55.0f;
                    is4 = false;
                    is5 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is5)
                {

                    newMessage.SetText($"{frogName} ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    is5 = false;
                    is6 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is6)
                {

                    newMessage.SetText($"{frogName} Well, it’s open now");
                    newMessage.fontSize = 55.0f;
                    is6 = false;
                    is7 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is7)
                {

                    newMessage.SetText($"{frogName} You can go");
                    newMessage.fontSize = 55.0f;
                    is7 = false;
                    is8 = true;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && is8)
                {

                    newMessage.SetText($"{frogName} ribbit-ribbit");
                    newMessage.fontSize = 55.0f;
                    is8 = false;
                    is9 = true;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && is9)
                {

                    newMessage.SetText($"{playerName} Finally. Am I going to get out of here soon?");
                    newMessage.fontSize = 55.0f;
                    is9 = false;
                    is10 = true;
                }


            }

        }
        


    }


    //text of Creature changes on space
    public void ChangeTextOnSpace()
    {
        if (isWatcher)
        {
            if (Input.GetKeyDown(KeyCode.Space) && is0)
            {

                newMessage.SetText("<color=#FC03CA>Creature:</color> Hehe, hi there");
                newMessage.fontSize = 0.07f;
                is0 = false;

                is1 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is1)
            {

                newMessage.SetText("<color=#FC03CA>Creature:</color> You look strange. How did you get here? Oh, nevermind, I see");
                newMessage.fontSize = 0.07f;
                is1 = false;
                is2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is2)
            {

                newMessage.SetText($"{playerName} What do you mean? Who the hell are you?");
                newMessage.fontSize = 0.07f;
                is2 = false;
                is3 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is3)
            {

                newMessage.SetText($"{fairyName} I'm Fairy and I'll be your helper during your awesome trip around our magical world!");
                newMessage.fontSize = 0.07f;
                is3 = false;
                is4 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is4)
            {

                newMessage.SetText($"{fairyName} So, you need a help?");
                newMessage.fontSize = 0.07f;
                is4 = false;
                is5 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is5)
            {

                newMessage.SetText($"{playerName} ...");
                newMessage.fontSize = 0.07f;
                is5 = false;
                is6 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is6)
            {

                newMessage.SetText($"{playerName} Yes");
                newMessage.fontSize = 0.07f;
                is6 = false;
                is7 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is7)
            {

                newMessage.SetText($"{fairyName} Hehe...What type of help?");
                newMessage.fontSize = 0.07f;
                is7 = false;
                is8 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is8)
            {

                newMessage.SetText($"{playerName} Are you joking?");
                newMessage.fontSize = 0.07f;
                is8 = false;
                is9 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is9)
            {

                newMessage.SetText($"{playerName} I appeared in a place unfamiliar to me, I don't remember how I got here and what happened, and you just laugh?");
                newMessage.fontSize = 0.06f;
                is9 = false;
                is10 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is10)
            {

                newMessage.SetText($"{playerName} Yeah, it's really funny. Am I sleeping? Just say me that its just a dream");
                newMessage.fontSize = 0.07f;
                is10 = false;
                is11 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is11)
            {

                newMessage.SetText($"{fairyName} No, it's a reall place");
                newMessage.fontSize = 0.07f;
                is11 = false;
                is12 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is12)
            {

                newMessage.SetText($"{fairyName} For me. But not for you I think");
                newMessage.fontSize = 0.07f;
                is12 = false;
                is13 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is13)
            {

                newMessage.SetText($"{playerName} What do you mean by this?");
                newMessage.fontSize = 0.07f;
                is13 = false;
                is14 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is14)
            {

                newMessage.SetText($"{fairyName} Well, its difficult to explain, but I think that you are not in the right reality. In different world, to be honest.");
                newMessage.fontSize = 0.06f;
                is14 = false;
                is15 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is15)
            {

                newMessage.SetText($"{playerName} Okay, assume that's the case. How I got here?");
                newMessage.fontSize = 0.07f;
                is15 = false;
                is16 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is16)
            {

                newMessage.SetText($"{fairyName} I don't know. Hehe");
                newMessage.fontSize = 0.07f;
                is16 = false;
                is17 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is17)
            {

                newMessage.SetText($"{playerName} What do you mean?");
                newMessage.fontSize = 0.07f;
                is17 = false;
                is18 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is18)
            {

                newMessage.SetText($"{fairyName} Like, you're not the first person who got here. And it always was different way to get here.");
                newMessage.fontSize = 0.07f;
                is18 = false;
                is19 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is19)
            {

                newMessage.SetText($"{fairyName} Maybe you eat, said or did something. Or maybe played?");
                newMessage.fontSize = 0.07f;
                is19 = false;
                is20 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is20)
            {

                newMessage.SetText($"{playerName} Perfect, and what I need to do to get out of here?");
                newMessage.fontSize = 0.07f;
                is20 = false;
                is21 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is21)
            {

                newMessage.SetText($"{fairyName} Our world consists of maaaany different locations and you are going to visit some of them, sounds cool, right? Hehe.");
                newMessage.fontSize = 0.06f;
                is21 = false;
                is22 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is22)
            {

                newMessage.SetText($"{fairyName} Every location has its portal such as behind me. As you can understand these portals will take you home. But just finding a portal is not enough! ");
                newMessage.fontSize = 0.06f;
                is22 = false;
                is23 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is23)
            {

                newMessage.SetText($"{playerName} Do I have to activate it or something like that?");
                newMessage.fontSize = 0.07f;
                is23 = false;
                is24 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is24)
            {

                newMessage.SetText($"{fairyName} You are absolutely right!");
                newMessage.fontSize = 0.07f;
                is24 = false;
                is25 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is25)
            {

                newMessage.SetText($"{fairyName} Oh, yeah, at each location, you will find different creatures, which can help you to activate it. But of course not for nothing, hehe ");
                newMessage.fontSize = 0.06f;
                is25 = false;
                is26 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is26)
            {

                newMessage.SetText($"{playerName} Okay, I think I got it. And that's all? ");
                newMessage.fontSize = 0.07f;
                is26 = false;
                is27 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is27)
            {

                newMessage.SetText($"{playerName} Okay, I think I got it. And that's all? ");
                newMessage.fontSize = 0.07f;
                is27 = false;
                is28 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is28)
            {

                newMessage.SetText($"{fairyName} I think yes. Don't be afraid, we’ll meet again, hehe. Now I need to go, so good luck, stranger!");
                newMessage.fontSize = 0.07f;
                is28 = false;
                is29 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is29)
            {
                btnClose.gameObject.SetActive(true);
                creature.SetActive(false);
                newMessage.SetText($"{playerName} I’ve definitely lost my mind…");
                newMessage.fontSize = 0.07f;
                is29 = false;

            }
        }
        if (isMushroom)
        {
            if (Input.GetKeyDown(KeyCode.Space) && is0)
            {
                creature.SetActive(false);
                newMessage.SetText($"{mushroomName} In darkness deep, where dreams don't keep, I wander lost, in restless sleep");
                newMessage.fontSize = 55.0f;
                is0 = false;
                is1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is1)
            {

                newMessage.SetText($"{mushroomName} There is a potion from it, written with puzzle unsolved, which I can't  resolve");
                newMessage.fontSize = 55.0f;
                is1 = false;
                is2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is2)
            {

                newMessage.SetText($"{mushroomName} But fear not, for I offer a deal!");
                newMessage.fontSize = 55.0f;
                is2 = false;
                is3 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is3)
            {

                newMessage.SetText($"{mushroomName} Listen to puzzles and bring what we need!");
                newMessage.fontSize = 55.0f;
                is3 = false;
                is4 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is4)
            {

                newMessage.SetText($"{mushroomName} And I'll open portal for you");
                newMessage.fontSize = 55.0f;
                is4 = false;
                is5 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is5)
            {

                newMessage.SetText($"{mushroomName} With patience and wit, we'll succeed!");
                newMessage.fontSize = 55.0f;
                is5 = false;
                is6 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is6)
            {

                newMessage.SetText($"{mushroomName} Beware its toxic allure, beware its name. Red poisoned cap and dots along its head," +
                                        " a warning sign it brings to you!");
                newMessage.fontSize = 55.0f;
                is6 = false;
                is7 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is7)
            {

                newMessage.SetText($"{mushroomName} It carries burdens ten times its weight, working together, never too late.");
                newMessage.fontSize = 55.0f;
                is7 = false;
                is8 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is8)
            {

                newMessage.SetText($"{mushroomName} In jungle dense you can find it on trees, " +
                        " But look carefully to where you live, it can be placed on the tops, not trees.");
                newMessage.fontSize = 55.0f;
                is8 = false;
                is9 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is9)
            {

                newMessage.SetText($"{mushroomName} With these clues, please, go ahead!");
                newMessage.fontSize = 55.0f;
                is9 = false;
                is10 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is10)
            {

                newMessage.SetText($"{mushroomName} Once you succeed, enter the portal, fulfil your need!");
                newMessage.fontSize = 55.0f;
                is10 = false;
                is11 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is11)
            {
                
                newMessage.SetText($"{mushroomName} No need for thanks, no words to share in this place");
                newMessage.fontSize = 55.0f;
                is11 = false;
                is12 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is12)
            {
                
                newMessage.SetText($"{mushroomName} Remember, just go ahead...");
                newMessage.fontSize = 55.0f;
                is12 = false;
                is13 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && is13)
            {
                
                newMessage.SetText($"{playerName} Oh, what's the frick");
                newMessage.fontSize = 55.0f;
                is13 = false;
                is14 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is14)
            {
                btnClose.gameObject.SetActive(true);
                newMessage.SetText($"{playerName} Anyway, I just need to make potion and get out of here");
                newMessage.fontSize = 55.0f;
                is14 = false;
                

            }

        }
        if (isFairyFinal)
        {
            if (Input.GetKeyDown(KeyCode.Space) && is0)
            {

                newMessage.SetText($"{playerName} Stupid Fairy!");
                newMessage.fontSize = 55.0f;
                is0 = false;

                is1 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && is1)
            {

                newMessage.SetText($"{playerName} I need to get away from this…");
                newMessage.fontSize = 55.0f;
                is1 = false;
                is2 = true;
                btnClose.gameObject.SetActive(true);
            }
        }
        

    }
}
