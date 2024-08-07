using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CursorController : MonoBehaviour
{
    public Texture2D imgCursor;
    ItemSorter itemSorter;


    // Start is called before the first frame update
    void Start()
    {
        itemSorter = GameObject.FindObjectOfType<ItemSorter>();
        Cursor.lockState = CursorLockMode.Confined;
        
        Cursor.SetCursor(imgCursor, Vector3.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F5)){

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            itemSorter.ReloadNumbers();
        }
       
    }
}
