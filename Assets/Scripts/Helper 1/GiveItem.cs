using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class GiveItem : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToAdd;

    [SerializeField]
    private GameObject controller;
    private bool isCollided;

    [HideInInspector]
    public bool btnClicked = false;

    [Header("Portal")]
    public GameObject portal;

    PlayerController pC;

    [SerializeField]
    private GameObject move;

    private void Start()
    {
        isCollided = false;
        btnClicked = false;
        pC = GameObject.FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if(portal.activeSelf)
        {
           
            pC.isMoving = true;
            move.SetActive(true);
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
    private void AddItemToMush()
    {
        if (controller.activeSelf && isCollided && btnClicked)
        {
            string btnName = EventSystem.current.currentSelectedGameObject.name;
            if (btnName != null)
            {
                if (btnName == "Potion Select")
                {

                    portal.SetActive(true);



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
        AddItemToMush();
    }


}

