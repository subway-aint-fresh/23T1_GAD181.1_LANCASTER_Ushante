using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpawner : MonoBehaviour
{
    //variable for desktop apps array
    public GameObject[] appsArray = new GameObject[44];

    //variable for pinned apps array
    public GameObject[] appsPinnedArray = new GameObject[44];

    // Start is called before the first frame update
    void Start()
    {   
        RandomizeApps();
        loadApps();
        loadPinnedApps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method responsible for randomizing the order in which the apps spawn
    public void RandomizeApps()
    {
        for (int t = 0; t < appsArray.Length; t++ )
        {
            GameObject tmp = appsArray[t];
            int r = Random.Range(t, appsArray.Length);
            appsArray[t] = appsArray[r];
            appsArray[r] = tmp;

            GameObject amp = appsPinnedArray[t];
            int s = Random.Range(t, appsPinnedArray.Length);
            appsPinnedArray[t] = appsPinnedArray[s];
            appsPinnedArray[s] = amp;
        }
    }

    //method responsible for desktop instantiation
    public void loadApps()
    {
        
        //this is responsible for instantiating the apps
        for ( int i = 0; i < appsArray.Length; i++)
        {
            appsArray[i] = Instantiate(appsArray[i], new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
            appsArray[i].transform.SetParent(GameObject.Find("Content").transform, false);

        }
    }

    //method responsible for pinned apps instantiation
    public void loadPinnedApps()
    {
        for ( int i = 0; i < 9; i++)
        {
            appsPinnedArray[i] = Instantiate(appsPinnedArray[i], new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
            appsPinnedArray[i].transform.SetParent(GameObject.Find("Pinned").transform, false);

        }
    }
}
