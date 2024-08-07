using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesChildre : MonoBehaviour
{
    public GameObject Children;
    PutJeweleries birdMaze;
    // Start is called before the first frame update
    void Start()
    {
        birdMaze = GameObject.FindObjectOfType<PutJeweleries>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(birdMaze.isBirdFinal == true)
            {
                Children.SetActive(true);

            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
