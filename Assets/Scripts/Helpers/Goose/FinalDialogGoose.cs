using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDialogGoose : MonoBehaviour
{
    private bool isCollided = false;
    //FollowChildren count = new FollowChildren();

    [HideInInspector]
    public bool isGooseFinal = false;

    [Header("Gooses")] 
    public GameObject goosesStart;
    [SerializeField]
    private GameObject gooses;

    [Header("Dialog")]
    [SerializeField]
    private GameObject detectMove;

    [HideInInspector]
    public bool missionSecond = false;

    PlayerControllerIslands playerControllerIslands;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject goose;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerIslands = GameObject.FindObjectOfType<PlayerControllerIslands>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollided = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(isCollided && Input.GetKeyDown(KeyCode.E) && FollowChildren.amountOfChildren >= 3)
        {
            isGooseFinal = true;
            gooses.SetActive(true);
            //gooses.SetActive(false);
            detectMove.SetActive(false);
            playerControllerIslands.isMoving = false;
            missionSecond = true;
            Debug.Log("Goose is ready to talk");
            player.transform.LookAt(goose.transform.position);

        }
       


    }
}
