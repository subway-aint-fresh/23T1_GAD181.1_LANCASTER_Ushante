using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpawner : MonoBehaviour
{
    public GameObject[] appsArray = new GameObject[44];

    // Start is called before the first frame update
    void Start()
    {   
        randomizeApps();
        
        //this is responsible for instantiating the apps
        for ( int i = 0; i < appsArray.Length; i++)
        {
            
            appsArray[i] = Instantiate(appsArray[i], new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
            appsArray[i].transform.SetParent(GameObject.Find("Content").transform, false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method responsible for randomizing the order in which the apps spawn
    public void randomizeApps()
    {
        for (int t = 0; t < appsArray.Length; t++ )
        {
            GameObject tmp = appsArray[t];
            int r = Random.Range(t, appsArray.Length);
            appsArray[t] = appsArray[r];
            appsArray[r] = tmp;
        }
    }

}
