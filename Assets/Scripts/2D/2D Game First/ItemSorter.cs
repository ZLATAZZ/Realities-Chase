using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSorter : MonoBehaviour
{
    //public Button btn;
    static int numberOfDestroyed;

    [SerializeField]
    private Image warning;

    [SerializeField]
    private GameObject panel;

    Drag3D canMove;

    private RectTransform rectTransform;


    private static Dictionary<string, int> items = new Dictionary<string, int>()
    {
        {"Witch", 0}, 
        {"Cyclops", 1},
        {"Fairy", 2 },
        {"Wall", 3 }
    };

    private void Start()
    {
        canMove = GetComponent<Drag3D>();
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if(warning.gameObject.activeSelf == true)
        {
            canMove.isDrag = false;
        }
        else
        {
            canMove.isDrag = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.tag;
        int number = items[name];

        chooseCharacter(number);

    }
    private void chooseCharacter(int number)
    {
        switch(number)
        {
            case 0:
                if (gameObject.CompareTag("For Witch"))
                {
                    
                    Destroy(gameObject);
                    
                }
                else
                {
                    warning.gameObject.SetActive(true);
                }
                break;
            case 1:
                if (gameObject.CompareTag("For Cyclops"))
                {
                    Destroy(gameObject);
                }

                else
                {
                    warning.gameObject.SetActive(true);
                }
                break;
            case 2:
                if (gameObject.CompareTag("For Fairy"))
                {
                    Destroy(gameObject);
                }
                else
                {
                    warning.gameObject.SetActive(true);
                }
                break;
            case 3:


                if (GetComponent<RectTransform>() != null)
                {
                    // Reset anchored position relative to the Canvas
                    GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                    Debug.Log("huh");
                }
                else
                {
                    Debug.Log("Is Null");
                }
                break;


        }
    }
    public void ReloadNumbers()
    {
        numberOfDestroyed = 0;
    }

    private void OnDestroy()
    {
        numberOfDestroyed = numberOfDestroyed + 1;
        Debug.Log(numberOfDestroyed);
        if(numberOfDestroyed == 11)
        {
            panel.SetActive(true);
        }
        
    }
}

