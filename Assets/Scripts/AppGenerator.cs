using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppGenerator : MonoBehaviour
{
    public App App; 

    //on start create the apps
    private void Start()
    {
        Generate();
    }

    void Generate()
    {
        DesktopManager.Instance.Add(App);
    }

}
