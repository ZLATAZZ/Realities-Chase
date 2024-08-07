using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour
{
    public Transform player;

    private void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player, Vector3.up);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello");
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
