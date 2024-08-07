using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidObjects : MonoBehaviour
{
    [SerializeField]
    private float moveAlnogZ;
    [SerializeField]
    private float moveAlnogX;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(collision.transform.position.x - moveAlnogX, collision.transform.position.y, transform.position.z - moveAlnogZ);
            
        }
    }
}
