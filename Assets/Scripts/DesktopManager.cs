using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopManager : MonoBehaviour
{
    public static DesktopManager Instance;
    public List<App> Apps = new List<App>();

    private void Awake()
    {
        Instance = this;
    }

    //method to add apps to desktop
    public void Add(App app)
    {
        Apps.Add(app);
    }

    //method to remove apps from desktop
    public void Remove(App app)
    {
        Apps.Remove(app);
    }
}
