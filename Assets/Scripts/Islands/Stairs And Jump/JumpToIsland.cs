using Unity.VisualScripting;
using UnityEngine;

public class JumpToIsland : MonoBehaviour
{
    [Header("Player's rigid body and force of jump")]
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private float forceJump;
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
            
            // Add upward impulse force
            playerRb.AddForce(Vector3.up * forceJump, ForceMode.Impulse);

            playerController.PlayerSpeed = 60.0f;

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            

           //playerController.PlayerSpeed = 10.0f;
        }
    }
}
