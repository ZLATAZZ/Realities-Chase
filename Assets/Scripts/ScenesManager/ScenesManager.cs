using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    [SerializeField]
    private string sceneName;
    // Start is called before the first frame update
    public void NewScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    
}