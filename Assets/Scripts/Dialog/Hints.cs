using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hints : MonoBehaviour
{

   
    [SerializeField]
    private Image img;
    [SerializeField]
    private Button inventory;

    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (portal.activeSelf)
        {
            img.gameObject.SetActive(true);
        }

    }
}
