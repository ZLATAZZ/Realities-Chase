using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastActiveWords : MonoBehaviour
{
    [SerializeField] private GameObject firstWords;
    [SerializeField] private GameObject secondWords;
    [SerializeField] private GameObject thirdWords;
    [SerializeField] private GameObject fourthWords;
    [SerializeField] private GameObject lastWords;
    [SerializeField] private Image imageWithWords;
    [SerializeField] private Image preImageWithWords;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            lastWords.SetActive(true);
            imageWithWords.gameObject.SetActive(true);
            preImageWithWords.gameObject.SetActive(false);
            firstWords.SetActive(false);
            secondWords.SetActive(false);
            thirdWords.SetActive(false);
            fourthWords.SetActive(false);

        }
    }
}
