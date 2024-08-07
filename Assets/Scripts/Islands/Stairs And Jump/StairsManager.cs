using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsManager : MonoBehaviour
{
    [Header("Upstairs")]
    [SerializeField]
    private GameObject lowRay;
    [SerializeField]
    private GameObject highRay;

    public float stepSmooth = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void FixedUpdate()
    {
        Climb();
    }
    void Climb()
    {
        RaycastHit lowHit;

        Ray low = new Ray(lowRay.transform.position, Vector3.forward);

        if(Physics.Raycast(low, out lowHit, 0.1f))
        {
            RaycastHit highHit;
            Ray high = new Ray(highRay.transform.position, Vector3.forward);

            if(!Physics.Raycast(high, out highHit, 0.2f))
            {
                gameObject.transform.position -= new Vector3(0f, -stepSmooth, 0f);

            }
        }
       
    }
}
