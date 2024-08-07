using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoMode : MonoBehaviour
{
    [SerializeField]
    private Camera main;
    [SerializeField]
    private Camera first;
    [SerializeField]
    private Camera second;
    [SerializeField]
    private Camera third;

    [SerializeField]
    private Canvas stickerGroup;
    [SerializeField]
    private Canvas stickerGroup2;
    [SerializeField]
    private Canvas stickerGroup3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Return) && main.gameObject.activeSelf == false){
            stickerGroup.gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Tab) ){ 
        
            first.gameObject.SetActive(true);
            main.gameObject.SetActive(false);
           
        
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            first.gameObject.SetActive(false);
            second.gameObject.SetActive(false);
            third.gameObject.SetActive(false);
            main.gameObject.SetActive(true);
        }
        if (first.gameObject.activeSelf)
        {
            if (stickerGroup.gameObject.activeSelf)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    stickerGroup.gameObject.SetActive(false);
                }

            }
            if (Input.GetKeyDown(KeyCode.Return) && main.gameObject.activeSelf == false)
            {
                stickerGroup.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                second.gameObject.SetActive(true);
                third.gameObject.SetActive(false);
                first.gameObject.SetActive(false);

            }

            else if (Input.GetKeyDown(KeyCode.Alpha3) )
            {
                second.gameObject.SetActive(false);
                third.gameObject.SetActive(true);
                first.gameObject.SetActive(false);

            }
        }

        if (second.gameObject.activeSelf)
        {
            if (stickerGroup2.gameObject.activeSelf)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    stickerGroup2.gameObject.SetActive(false);
                }

            }
            if (Input.GetKeyDown(KeyCode.Return) && main.gameObject.activeSelf == false)
            {
                stickerGroup2.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                second.gameObject.SetActive(false);
                third.gameObject.SetActive(true);
                first.gameObject.SetActive(false);

            }
        }

        if (third.gameObject.activeSelf)

        {
            if (stickerGroup3.gameObject.activeSelf)
            {

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    stickerGroup3.gameObject.SetActive(false);
                }

            }
            if (Input.GetKeyDown(KeyCode.Return) && main.gameObject.activeSelf == false)
            {
                stickerGroup3.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                second.gameObject.SetActive(true);
                third.gameObject.SetActive(false);
                first.gameObject.SetActive(false);

            }
        }

    }
}
