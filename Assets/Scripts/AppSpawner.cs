using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

public class AppSpawner : MonoBehaviour
{
    //variable for desktop apps array
    public List<AppInfo> appsArray = new();

    //variable for pinned apps array
    public List<AppInfo> appsPinnedArray = new();

    // Start is called before the first frame update
    void Start()
    {   
        RandomizeApps();
        LoadApps();
        LoadPinnedApps();
    }

    // Update is called once per frame
    void Update()
    {
        //method to compare tags between desktop and pinned apps
    }

    //method responsible for randomizing the order in which the apps spawn
    private void RandomizeApps()
    {
        for (int t = 0; t < appsArray.Count; t++ )
        {
            AppInfo tmp = appsArray[t];
            int r = Random.Range(t, appsArray.Count);
            appsArray[t] = appsArray[r];
            appsArray[r] = tmp;

            AppInfo amp = appsPinnedArray[t];
            int s = Random.Range(t, appsPinnedArray.Count);
            appsPinnedArray[t] = appsPinnedArray[s];
            appsPinnedArray[s] = amp;
        }
    }

    //method responsible for desktop instantiation
    private void LoadApps()
    {
        
        //this is responsible for instantiating the apps
        for ( int i = 0; i < appsArray.Count; i++)
        {
            appsArray[i] = Instantiate(appsArray[i], new Vector3 (0,0,0), Quaternion.identity); 
            appsArray[i].transform.SetParent(GameObject.Find("Content").transform, false);
        }
    }

    //method responsible for pinned apps instantiation
    private void LoadPinnedApps()
    {
        for ( int i = 0; i < 9; i++)
        {
            appsPinnedArray[i] = Instantiate(appsPinnedArray[i], new Vector3 (0,0,0), Quaternion.identity); 
            appsPinnedArray[i].transform.SetParent(GameObject.Find("Pinned").transform, false);
        }
    }

    //method to compare tags between desktop and pinned apps, add to onclick of prefabs
    private void OnEnable()
    {
        GameEvents.onSendAppDataEvent += ReadData;
    }

    private void OnDisable()
    {
        GameEvents.onSendAppDataEvent -= ReadData;
    }

    private void ReadData(string appName)
    {
        for ( int i = 0; i < appsPinnedArray.Count; i++)
        {
            if (appsPinnedArray[i].appName == appName)
            {
                appsPinnedArray.RemoveAt(i);
                //destroy the object aswell
                //score++
            }
        }
    }
}

//observer pattern