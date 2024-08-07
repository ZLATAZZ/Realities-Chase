using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDetect1 : MonoBehaviour
{
    PlayerControllerIslands movingController;
 

    [HideInInspector]
    public bool isBird1Start = false;
  

    [Header("Detect Movement")]
    [SerializeField]
    private GameObject detectMove;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {

            Debug.Log("Collided");
            detectMove.SetActive(false);
            isBird1Start = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(detectMove.activeSelf == false)
        {
            movingController.isMoving = false;
            if(isBird1Start)
            {
                player.transform.LookAt(bird.transform.position);
            }
           

        }
      
        
    }
}
