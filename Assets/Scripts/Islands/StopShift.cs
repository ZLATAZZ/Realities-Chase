using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopShift : MonoBehaviour
{
    PlayerControllerIslands playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerControllerIslands>();
    }

    private void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            

            playerController.PlayerSpeed = 10.0f;

        }
    }
}
