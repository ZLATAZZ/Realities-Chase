using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI text1;
    public string[] lines;
    private int index;
    [SerializeField]
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
       
        text1.text = string.Empty;
        //TypeText();
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void TypeText()
    {
        index = 0;
        StartCoroutine(PrintText());
    }
    IEnumerator PrintText()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            index++;
            text1.text += c;
            yield return new WaitForSeconds(speed);
        }

        btn.gameObject.SetActive(true);
      
    }
}
