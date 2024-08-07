using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerIslands : MonoBehaviour
{
    [Header("Player Controller")]
    public float PlayerSpeed;
    public float JumpSpeed = 10.0f;
    public float downSpeed;
    

    [Header("Animation of Gooses")]
    [SerializeField]
    private Animator arm1;
    [SerializeField]
    private Animator arm2;
    [SerializeField]
    private Animator arm3;
    [SerializeField]
    private Animator arm4;
    //private variables for moving
    private float moveX;
    private float moveY;
    private float moveZ;

    private float lookHorizontal;
    private float lookVertical;
    private float lookX, lookY;

    private Rigidbody rb;

    private bool isJump = true;
   

    [SerializeField]
    private float sensetivity; 
    [SerializeField]
    private Transform cameraPlayer;

    //check if we should take control over Player
    
    public bool isMoving;

    
    
    private void Awake()
    {
        //highRay.transform.position = new Vector3(highRay.transform.position.x, stepHeight, highRay.transform.position.z);
        // Hide the cursor
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //!!!!!!!!DON'T FORGET TO CHANGE THIS TO FALSE!!!!!!!!!!!
        //isMoving = true;
        rb = GetComponent<Rigidbody>();
       


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        {
            moveX = Input.GetAxis("Horizontal");

            moveY = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * moveY * PlayerSpeed * Time.deltaTime);

            transform.Translate(Vector3.right * moveX * PlayerSpeed * Time.deltaTime);

            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                arm1.SetTrigger("Move1");
                arm2.SetTrigger("Move2");
                arm3.SetTrigger("Move3");
                arm4.SetTrigger("Move4");
            }
            else
            {
                arm1.SetTrigger("Normal1");
                arm2.SetTrigger("Normal2");
                arm3.SetTrigger("Normal3");
                arm4.SetTrigger("Normal4");
            }

        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
        if (isMoving)

        {
            
            lookHorizontal = Input.GetAxis("Mouse X") * sensetivity * Time.deltaTime;
            lookVertical = Input.GetAxis("Mouse Y") * sensetivity * Time.deltaTime;

            lookX -= lookVertical;
            lookY += lookHorizontal;

            lookX = Mathf.Clamp(lookX, -70f, 40f);

            // Player Rotation
            transform.rotation = Quaternion.Euler(0, lookY, 0);

            // Camera Rotation
            cameraPlayer.rotation = Quaternion.Euler(lookX, lookY, 0);
            if (Input.GetKeyDown(KeyCode.Space) && isJump)
            {
                rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
                isJump = false;
            }
            else
            {
                rb.AddForce(Vector3.down * downSpeed);
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        isJump = true;


    }


}
