using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject secondWords;
    [SerializeField] private GameObject thirdWords;
    [SerializeField] private GameObject fourthWords;
   
    // Start is called before the first frame update
    void Start()
    {
        Invoke("OpenSecondWords", 16.10f);
        Invoke("OpenThirdWords", 30.14f);
        Invoke("OpenFourthWords", 43.14f);
    }

    private void OpenSecondWords()
    {
        secondWords.SetActive(true);
    }

    private void OpenThirdWords()
    {
        thirdWords.SetActive(true);
    }
    private void OpenFourthWords()
    {
        fourthWords.SetActive(true);
    }
}
