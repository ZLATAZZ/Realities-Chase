using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowChildren : MonoBehaviour
{
    [Header("Player to Follow")]
    [SerializeField]
    private GameObject player;

    [Header("Distance from player")]
    [SerializeField]
    private float xPos;
    [SerializeField]
    private float zPos;



    [HideInInspector]
    public static int amountOfChildren = 0;

    private bool isCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
               isCollided = true;
               amountOfChildren += 1;

            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(isCollided)
        {
            Debug.Log($"{"Children:"} {amountOfChildren}");
            transform.position = new Vector3(player.transform.position.x - xPos, transform.position.y, player.transform.position.z - zPos);
            transform.rotation = player.transform.rotation;
        }

       
        
    }
}
