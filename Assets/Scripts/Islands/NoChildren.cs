using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoChildren : MonoBehaviour
{
    public GameObject Children;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Children.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
