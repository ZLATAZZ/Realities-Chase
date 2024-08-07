using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventFail : MonoBehaviour
{
    [Header("Player Position")]
    [SerializeField]
    private GameObject player;

    //private variable
    Vector3 initialPos;

    private void Start()
    {
        initialPos = player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = initialPos;
        }
    }

}
