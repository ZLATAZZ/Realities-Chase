using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public Transform objectToFollow;
    public GameObject[] initialObjs;
    public float speed;
    public Transform[] positions;
    private GameObject instance;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnFishes();
    }

    // Update is called once per frame
    void Update()
    {
      if(instance != null)
        {
            instance.transform.position = Vector3.MoveTowards(instance.transform.position, objectToFollow.position, speed);
            instance.transform.LookAt(objectToFollow.position);
        }
            
        
    }

    private void SpawnFishes()
    {
        StartCoroutine(SpawnObj());
    }

    IEnumerator SpawnObj()
    {
        while (true)
        {
            
            instance = Instantiate(initialObjs[Random.Range(0, 3)], positions[Random.Range(0, 5)].position, Quaternion.identity);
           
            yield return new WaitForSeconds(8f);
            Destroy(instance);
        }
      
    }
}
