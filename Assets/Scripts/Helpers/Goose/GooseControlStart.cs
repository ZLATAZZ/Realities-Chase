using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseControlStart : MonoBehaviour
{
    PlayerControllerIslands movingController;
    PutJeweleries putJeweleries;

    [HideInInspector]
    public bool isGoose = false;



    [Header("Detect Movement")]
    [SerializeField]
    private GameObject detectMove;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject goose;

    // Start is called before the first frame update
    void Start()
    {
        movingController = GameObject.FindObjectOfType<PlayerControllerIslands>();
        putJeweleries = GameObject.FindObjectOfType<PutJeweleries>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && putJeweleries.missionFirst )
        {
            Debug.Log("Collided");
            detectMove.SetActive(false);
            isGoose = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (detectMove.activeSelf == false)
        {
            movingController.isMoving = false;

        }
        if(isGoose)
        {
            player.transform.LookAt(goose.transform.position);
        }


    }
}
