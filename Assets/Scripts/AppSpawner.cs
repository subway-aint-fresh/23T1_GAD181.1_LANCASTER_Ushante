using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpawner : MonoBehaviour
{
    //github prefab (change to an array of apps later)
    public GameObject github;

    //content folder
    public GameObject content;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(github, new Vector3 (0,0,0), Quaternion.identity) as GameObject; 
        go.transform.SetParent(GameObject.Find("Content").transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
