using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpawner : MonoBehaviour
{
    public GameObject[] appsArray = new GameObject[44];

    // Start is called before the first frame update
    void Start()
    {   

        //make the array randomized

        for ( int i = 0; i < 44; i++)
        {
            for (int t = 0; t < appsArray.Length; t++ )
            {
                GameObject tmp = appsArray[t];
                int r = Random.Range(t, appsArray.Length);
                appsArray[t] = appsArray[r];
                appsArray[r] = tmp;
            }
            appsArray[i] = Instantiate(appsArray[i], new Vector3 (1,1,1), Quaternion.identity) as GameObject; 
            appsArray[i].transform.SetParent(GameObject.Find("Content").transform, false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
