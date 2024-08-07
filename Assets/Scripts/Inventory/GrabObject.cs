using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public Item item;
    private bool isGrabbed;
    public GameObject objectToCollect;
    //private bool isNull;

    // Start is called before the first frame update
    void Start()
    {
        isGrabbed = false;
        //isNull = false;
    }

    // Update is called once per frame
    void Update()
    {
        onGrab();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            isGrabbed = true;
            Debug.Log("Is grabbed");
        }
    }

    void onGrab()
    {
        if(isGrabbed && Input.GetKeyDown(KeyCode.E)) {

            objectToCollect.SetActive(false);
            ItemManager.Instance.Add(item);
            Debug.Log("Is Grabbed");
            
        }
    }
}
