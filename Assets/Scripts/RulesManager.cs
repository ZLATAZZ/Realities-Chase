using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RulesManager : MonoBehaviour
{
    [SerializeField] private Image rules;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadRules());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadRules()
    {
       
        yield return new WaitForSeconds(10.0f);
        rules.gameObject.SetActive(false);
    }
}
