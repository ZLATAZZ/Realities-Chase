using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Player Controller")]
    public float PlayerSpeed = 3000f;
    private float moveX;
    private float moveY;

    private float lookHorizontal;
    private float lookVertical;
    private float lookX, lookY;

    [SerializeField]
    private float sensetivity;
    [SerializeField]
    private Transform cameraPlayer;

    //check if we should take control over Player
    [HideInInspector]
    public bool isMoving;

    FunctionManager functionManager;

    


    [Header("Player Can Climb")]
    
   public LayerMask layer;
   

    private void Awake()
    {
        //highRay.transform.position = new Vector3(highRay.transform.position.x, stepHeight, highRay.transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        //!!!!!!!!DON'T FORGET TO CHANGE THIS TO FALSE!!!!!!!!!!!
        isMoving = false;
        functionManager = FindObjectOfType<FunctionManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {

           
            
            moveX = Input.GetAxis("Horizontal");

            moveY = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * moveY * Time.deltaTime * PlayerSpeed);

            transform.Translate(Vector3.right * moveX * Time.deltaTime * PlayerSpeed);
            lookHorizontal = Input.GetAxis("Mouse X") * sensetivity * Time.deltaTime;
            lookVertical = Input.GetAxis("Mouse Y") * sensetivity * Time.deltaTime;

            lookX -= lookVertical;
            lookY += lookHorizontal;

            lookX = Mathf.Clamp(lookX, -70f, 40f);



            //Player Rotation
            transform.rotation = Quaternion.Euler(0, lookY, 0);

            //Camera Rotation
            cameraPlayer.rotation = Quaternion.Euler(lookX, lookY, 0);


            //Rotation

            //Climb();


        }



    }

    void Climb()
    {
        Ray ray = new Ray(transform.position, -transform.up);

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit, layer))
        {
            Vector3 newPos = transform.position;
            newPos.y = hit.point.y + 3f;
            transform.position = newPos;

        }



    }


}

