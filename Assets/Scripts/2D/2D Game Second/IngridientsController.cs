using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IngridientsController : MonoBehaviour
{
    Drag3D isDragging;
    static int countPos, posE, posG, posP, posM, posF;
    private RectTransform rectTransform;
    private int pos;

    [Header("Positions of Ingridients")]
    [SerializeField]
    private Transform initialPos;

    [Header("For failures")]
    [SerializeField]
    private Image image;
    [SerializeField]
    private GameObject block;

    [Header("Animation blocks")]
    [SerializeField]
    private Image imgAnim;
    [SerializeField]
    private GameObject addAnim;
    [SerializeField]
    private GameObject music;

    [Header("Animation of Transition")]
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private GameObject bubbleSound;


    //private bool isEnd;

    [Header("Black Screen")]
    [SerializeField]
    private Image blackScreen;
    

    private static Dictionary<string, int> tags = new Dictionary<string, int>()
    {
        {"Eye", 0},
        {"Garlic", 1},
        {"Poison", 2},
        {"Mushroom", 3},
        {"Frog", 4}
    };
   
    private static Dictionary<int, Vector3> newPositions = new Dictionary<int, Vector3>()
        {
            {0, new Vector3(-162f, -6f, 0f)},
            {1, new Vector3(71f, 13f, 0f)},
            {2, new Vector3(-27f, 55f, 0f)},
            {3, new Vector3(132f, 38f, 0f)},
            {4, new Vector3(-59f, -6f, 0f) }
            
        };



    // Start is called before the first frame update
    void Start()
    {
       isDragging = GetComponent<Drag3D>();
       rectTransform = GetComponent<RectTransform>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pot")) {

            //get the values
            string tag = gameObject.tag;
            pos = tags[tag];

            
            rectTransform.anchoredPosition3D = newPositions[pos];
            
            isDragging.isMove = false;
            countPos += 1;
            

            //Call the function what to do on Trigger
            CalculatePosition();
            OnEnd();
            

        }
    }
    IEnumerator setAddAnimation()
    {
        addAnim.SetActive(true);
        bubbleSound.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        addAnim.SetActive(false);
        bubbleSound.SetActive(false);
    }

    private void CalculatePosition()
    {
        switch (pos)
        {
            case 0:
                StartCoroutine(setAddAnimation());
                if(posG == 0 && posF == 0 && posM == 0 && posP == 0)
                {
                    posE = 1;
                   

                }
                else
                {
                    posE = 0;

                }
                isDragging.isDrag = false;
                
                break;
            case 1:
                StartCoroutine(setAddAnimation());
                if (posE == 1 && posF == 0 && posM == 0 && posP== 0)
                {
                    posG = 1;
                    
                }
                else
                {
                    posG = 0;

                }
                isDragging.isDrag = false;

                break;
            case 2:
                StartCoroutine(setAddAnimation());
                if (posE == 1 && posG == 1 && posM == 0 && posF == 0)
                {
                    posP = 1;
                    
                }
                else
                {
                    posP = 0;
                }
                isDragging.isDrag = false;

                break;
            case 3:
                StartCoroutine(setAddAnimation());
                if (posE == 1 && posG == 1 && posP == 1 && posF== 0)
                {
                    posM = 1;
                   
                }
                else
                {
                    posM = 0;
                }
                isDragging.isDrag = false;

                break;
            case 4:
                StartCoroutine(setAddAnimation());
                if (posE == 1 && posG == 1 && posP== 1 && posM == 1)
                {
                    posF = 1;
                    
                }
                else
                {
                    posF = 0;

                }
                isDragging.isDrag = false;
                
                break;
        }
        
    }
    IEnumerator StartTransition()
    {
        yield return new WaitForSeconds(3f);
        imgAnim.gameObject.SetActive(true);
        music.SetActive(true);
        anim.SetTrigger("AnimationFirst");
        yield return new WaitForSeconds(4.5f);
        blackScreen.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Intro to 3D");

    }
    private void OnEnd()
    {
        if (posG == 1 && posE == 1 && posF == 1 && posM == 1 && posP == 1)
        {

            Debug.Log("All right");

            //Put Animation of Explosion here
            StartCoroutine(StartTransition());
            // and start loading scene after this
            


        }
        else
        {
            if(countPos == 5)
            {
                Debug.Log("All Wrong");
               
                image.gameObject.SetActive(true);
                block.SetActive(true);
                
                ResetPositions();
               


            }
            
        }

    }

    public void ResetPositions()
    {
        Debug.Log("Positions is reset");
        countPos = 0;
        posE = 0;
        posG = 0;
        posP = 0;
        posM = 0;
        posF = 0;
        
        IngridientsController[] ingridients = FindObjectsOfType<IngridientsController>();
        foreach (IngridientsController obj in ingridients)
        {
            obj.isDragging.isDrag = true;
            obj.gameObject.transform.position = obj.initialPos.position;
            //obj.gameObject.SetActive(true) ;
            
        }


    }


}
