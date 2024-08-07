using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PutJeweleries : MonoBehaviour
{
    [Header("Object To Add")]
    [SerializeField]
    private GameObject[] objectsToAdd;

    [Header("Dialog")]
    [SerializeField]
    private GameObject detectMove;


    [Header("Buttons of Inventory")]
    [SerializeField]
    private Button[] btns;
    public Image inventory;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject bird;


    [SerializeField]
    private GameObject controller;

    [HideInInspector]
    public bool isBirdFinal = false;

    [HideInInspector]
    public bool missionFirst = false;

   PlayerControllerIslands playerControllerIslands;

   

    private bool isCollided, btnClicked;
     void Start()
    {
        isCollided = false;
        btnClicked = false;
        playerControllerIslands = GameObject.FindObjectOfType<PlayerControllerIslands>();
        
        
    }

     void Update()
    {
        if (objectsToAdd[0].activeSelf && objectsToAdd[1].activeSelf && objectsToAdd[2].activeSelf)
        {
           
            if(isCollided)
            {

                isBirdFinal = true;
                inventory.gameObject.SetActive(false);
                missionFirst = true;
                Debug.Log($"{isBirdFinal} {"Bird is the following"}");
                //Destroy(controller);
            }


        }
        if (isCollided)
        {
            if (btns[0].gameObject.activeSelf && btns[1].gameObject.activeSelf && btns[2].gameObject.activeSelf)
            {
                detectMove.SetActive(false);
                playerControllerIslands.isMoving = false;
               
                
            }
            
        }

        if (isBirdFinal)
        {
            player.transform.LookAt(bird.transform.position);
        }
       
       


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (btns[0].gameObject.activeSelf && btns[1].gameObject.activeSelf && btns[2].gameObject.activeSelf)
            {
                isCollided = true;
                Debug.Log("Collided Bird");
            }
           
        }

    }

    // Function to add item to the pot based on the button clicked
    private void AddItemToBird()
    {
        if (controller.activeSelf && isCollided && btnClicked)
        {
            string btnName = EventSystem.current.currentSelectedGameObject.name;
            if (btnName != null)
            {
                switch (btnName)
                {
                    case "Glasses Select":
                        if (objectsToAdd.Length > 0)
                        {
                            objectsToAdd[0].SetActive(true);

                        }
                        break;
                    case "Pearls Select":
                        if (objectsToAdd.Length > 1)
                        {
                            objectsToAdd[1].SetActive(true);
                        }
                        break;
                    case "Hat Select":
                        if (objectsToAdd.Length > 2)
                        {
                            objectsToAdd[2].SetActive(true);
                        }
                        break;
                    
                }
            }

            else
            {
                Debug.LogError("Error");

            }

        }

    }

    public void IsClicked()
    {
        btnClicked = true;
        AddItemToBird();
    }
}
