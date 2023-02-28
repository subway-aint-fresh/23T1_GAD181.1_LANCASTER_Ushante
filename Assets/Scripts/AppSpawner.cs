using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpawner : MonoBehaviour
{
    public GameObject[] appsArray = new GameObject[44];

    // Start is called before the first frame update
    void Start()
    {   

        for ( int i = 0; i < 44; i++)
        {
            appsArray[i] = Instantiate(appsArray[i], new Vector3 (1,1,1), Quaternion.identity) as GameObject; 
            appsArray[i].transform.SetParent(GameObject.Find("Content").transform, false);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
