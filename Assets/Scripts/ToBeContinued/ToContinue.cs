using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToContinue : MonoBehaviour
{
    private bool isKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            
        {
            isKey = true;
            Debug.Log("Loaded");
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isKey) 
        {
            gameObject.SetActive(false);


        }
        if (gameObject.activeSelf == false)
        {
            SceneManager.LoadScene("ToBe");
        }
        
    }
}
