using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [Header("Bounds For 2D Game")]
    [SerializeField]
    private float boundsPositive;
    [SerializeField]
    private float boundsNegative;
    [SerializeField]
    private float boundsTop;
    [SerializeField]
    private float boundsBottom;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
       if(transform.position.x > boundsPositive)
        {
            
            transform.position = new Vector3(boundsPositive - 5f, transform.position.y, transform.position.z);
        }
       else if(transform.position.x < boundsNegative)
        {
           
            transform.position = new Vector3(boundsNegative, transform.position.y, transform.position.z);
        }
       else if(transform.position.y > boundsTop)
        {
            transform.position = new Vector3(transform.position.x, boundsTop, transform.position.z);
        }
       else if(transform.position.y < boundsBottom)
        {
            transform.position = new Vector3(transform.position.x, boundsBottom, transform.position.z);

        }
       

    }
   
}
