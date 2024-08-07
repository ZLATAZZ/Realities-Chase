using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Player to follow")]
    [SerializeField]
    private Transform camera;

    public Transform yPos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if (camera != null) // Ensure camera is assigned properly
        {
            // Adjust x and z based on the camera's position
            float newX = camera.position.x + 3000f;
            float newY = yPos.position.y;
            float newZ = camera.position.z ;

            // Ensure newY doesn't go below 2
            

            // Set the object's position
            transform.position = new Vector3(newX, newY, newZ);

            // Set rotation to zero if necessary
            //transform.rotation = Quaternion.Euler(Vector3.zero);
        }
    }

    

}
