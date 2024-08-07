using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LastDetect : MonoBehaviour
{
    [HideInInspector]
    public bool isFrogFinal = false;

    [Header("Dialog")]
    [SerializeField]
    private GameObject detectMove;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject frog;

    PlayerControllerIslands playerControllerIslands;
    PutJeweleries isBirdLast;
    FinalDialogGoose isGooseLast;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerIslands = GameObject.FindObjectOfType<PlayerControllerIslands>();
        isBirdLast = GameObject.FindObjectOfType<PutJeweleries>();
        isGooseLast = GameObject.FindObjectOfType<FinalDialogGoose>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(isBirdLast.missionFirst && isGooseLast.missionSecond)
            {
                isFrogFinal = true;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isFrogFinal)
        {
            detectMove.SetActive(false);
            playerControllerIslands.isMoving = false;
            player.transform.LookAt(frog.transform.position);
        }
        
    }

    
}
