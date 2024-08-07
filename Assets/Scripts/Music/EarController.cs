using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarController : MonoBehaviour
{
   private AudioSource source;
  
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("ChangeSound", 2f, 1.5f);

    }

    void ChangeSound()
    {
     
        source.panStereo = Mathf.PingPong(Time.time, 2f) - 1f;
    }
}
