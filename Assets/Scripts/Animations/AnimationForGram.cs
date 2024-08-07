using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationForGram : MonoBehaviour
{
    public GameObject handler;
    public GameObject gram;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handler.transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        gram.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f );
    }
}

