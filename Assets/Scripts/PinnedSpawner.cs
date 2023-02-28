using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinnedSpawner : MonoBehaviour
{
    public GameObject[] appsArray = new GameObject[44];

    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        myObject.GetComponent<AppSpawner>().RandomizeApps();
        
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

}
