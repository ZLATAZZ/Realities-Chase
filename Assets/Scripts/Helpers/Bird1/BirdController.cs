using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    [Header("Buttons for selection")]
    [SerializeField]
    private Button[] butns;

    [Header("Object to collect")]
    [SerializeField]
    private GameObject[] objects;


    [Header("Put Clothes")]
    [SerializeField]
    private GameObject putJeweleries;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateButtons();
        PutJewleries();
    }

    void CreateButtons()
    {
        if (objects[0].activeSelf == false)
        {
            butns[0].gameObject.SetActive(true);
        }
        if (objects[1].activeSelf == false)
        {
            butns[1].gameObject.SetActive(true);
        }
        if (objects[2].activeSelf == false)
        {
            butns[2].gameObject.SetActive(true);
        }
    }
    void PutJewleries()
    {
        if (butns[0].gameObject.activeSelf && butns[1].gameObject.activeSelf && butns[2].gameObject.activeSelf) {
            
            putJeweleries.SetActive(true);
        
        }
    }
}
