using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PotManager : MonoBehaviour
{
    [Header("Buttons for adding elements")]
    public Button[] btns;

    [Header("Items to collect")]
    public Item[] items;

    [Header("Objects to collect")]
    public GameObject[] objectsToCollect;

    [Header("Collider for Pot - final")]
    public GameObject colliderController;

    

    [Header("Collider for communicating with Helper")]
    [SerializeField]
    private GameObject mushroomController;



    // Update is called once per frame
    void Update()
    {
        //Detect if we it is time to collide with Pot
        if(colliderController != null)
        {
            if (objectsToCollect[0].activeSelf == false && objectsToCollect[1].activeSelf == false && objectsToCollect[2].activeSelf == false)
            {
                colliderController.SetActive(true);
                CreatButton();

            }
        }
        
        else {
           
            btns[0].gameObject.SetActive(false);
            btns[1].gameObject.SetActive(false);
            btns[2].gameObject.SetActive(false);

            if (objectsToCollect[3].activeSelf == false)
            {
                //If the last object - potion is collected, then we can "ask" msuhroom for a key
                btns[3].gameObject.SetActive(true);
                if(mushroomController != null)
                {
                    mushroomController.SetActive(true);
                }
                

            }
               
        
        }
        
        
    }

    public void CreatButton()
    {
        if (items[0].id == 1 && objectsToCollect[0].activeSelf == false)
        {

            
            btns[0].gameObject.SetActive(true);
        }
        if (items[1].id == 2 && objectsToCollect[1].activeSelf == false)
        {
            
            btns[1].gameObject.SetActive(true);
        }
        if (items[2].id == 3 && objectsToCollect[2].activeSelf == false)
        {
            btns[2].gameObject.SetActive(true);
        }
        
    }

    
}
