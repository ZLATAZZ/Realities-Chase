using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidedItems : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided");
        }
    }
}
