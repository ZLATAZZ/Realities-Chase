using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAnotherWorld : MonoBehaviour
{
    [SerializeField]
    private string sceneName;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(sceneName + " is about to load");
            SceneManager.LoadScene(sceneName);
        }
    }
}
