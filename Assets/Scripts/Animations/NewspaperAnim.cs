using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewspaperAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float valueX = 3.0f + Mathf.PingPong(Time.time, 1.0f);
        float valueY = 20.0f + Mathf.PingPong(Time.time, 1.0f);
        gameObject.transform.localScale = new Vector3(valueX, valueY, valueX);
       

    }
}
