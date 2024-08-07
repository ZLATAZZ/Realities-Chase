using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AddToPot : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsToAdd;

    [SerializeField]
    private GameObject controller;

    [SerializeField]
    private GameObject greenTop;

    [SerializeField]
    private GameObject posion;

    [SerializeField]
    private GameObject move;

    private bool isCollided, btnClicked;

    PlayerController pC;

    private void Start()
    {
        isCollided = false;
        btnClicked = false;
        pC = GameObject.FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if (objectsToAdd[0].activeSelf && objectsToAdd[1].activeSelf && objectsToAdd[2].activeSelf) {
        
            greenTop.SetActive(true);
            Destroy(controller);
            posion.SetActive(true);
            move.SetActive(true);
            pC.isMoving = true;



        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollided = true;
            move.SetActive(false);
            pC.isMoving = false;
        }
        
    }

    // Function to add item to the pot based on the button clicked
    private void AddItemToPot()
    {
        if(controller.activeSelf && isCollided && btnClicked)
        {
            string btnName = EventSystem.current.currentSelectedGameObject.name;
            if (btnName != null)
            {
                switch (btnName)
                {
                    case "Mushroom Select":
                        if (objectsToAdd.Length > 0)
                        {
                            objectsToAdd[0].SetActive(true);

                        }
                        break;
                    case "Ant Select":
                        if (objectsToAdd.Length > 1)
                        {
                            objectsToAdd[1].SetActive(true);
                        }
                        break;
                    case "Vine Select":
                        if(objectsToAdd.Length > 2)
                        {
                            objectsToAdd[2].SetActive(true);
                        }
                        break;
                    case "Potion Select":
                        if(objectsToAdd.Length > 3)
                        {
                            objectsToAdd[3].SetActive(true);
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
        AddItemToPot();
    }
        

}
