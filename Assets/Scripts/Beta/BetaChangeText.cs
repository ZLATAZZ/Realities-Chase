using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class BetaChangeText : MonoBehaviour
{
    [SerializeField] private bool isFairyBeta;
    [SerializeField] private TMP_Text newMessage;
    [SerializeField] private Image dialogWindow;
    private bool player0, player1, player2, player3, player4, player5, player6, player7 = false;

    PlayerControllerIslands movingController;
    private static string fairyName = "<color=#fc03ca>Fairy:</color>";
    // Start is called before the first frame update
    void Start()
    {
        if (isFairyBeta)
        {
            movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
            movingController.isMoving = false;
           
            newMessage.SetText("...");
            
            player0 = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTalkBeta();
    }

    void PlayerTalkBeta()
    {
        if (isFairyBeta)
        {
            if (Input.GetKeyDown(KeyCode.Space) && player0)
            {

                newMessage.SetText($"{fairyName} Hello, player! Welcome to Beta of Realities Chase");
                newMessage.fontSize = 0.07f;
                player0 = false;
                player1 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player1)
            {
                newMessage.SetText($"{fairyName} Ohhh. Maybe, you're wondering 'What?' 'Where?' 'Why?' 'When?'");
                newMessage.fontSize = 0.07f;
                player1 = false;
                player2 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player2)
            {
                newMessage.SetText($"{fairyName} Hehe, for this you need a full version");
                newMessage.fontSize = 0.07f;
                player2 = false;
                player3 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player3)
            {
                newMessage.SetText($"{fairyName} But, don't worry. It'll be released on <color=red> 22nd of May, 2024</color>. Very soon!");
                newMessage.fontSize = 0.07f;
                player3 = false;
                player4 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player4)
            {
                newMessage.SetText($"{fairyName} But...I would really like you to go away from this place, for now...");
                newMessage.fontSize = 0.07f;
                player4 = false;
                player5 = true;

            }
            else if (Input.GetKeyDown(KeyCode.Space) && player5)
            {
                newMessage.SetText($"{fairyName} Because, mine creators wouldn't be very happy, if I let you know our story earlier...");
                newMessage.fontSize = 0.07f;
                player5 = false;
                player6 = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && player6)
            {
                newMessage.SetText($"{fairyName} So, you can go through the portal behind me. Good luck, player, and come back! I'm waiting for you...");
                newMessage.fontSize = 0.07f;
                player6 = false;
                player7 = true;
            }

            else if( Input.GetKeyDown(KeyCode.Space) && player7)
            {
                movingController.isMoving = true;
                player7 = false;
                dialogWindow.gameObject.SetActive(false);
            }

        }
    }
}
