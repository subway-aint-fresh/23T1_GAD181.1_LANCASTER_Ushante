//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DesktopManager : MonoBehaviour
//{
//    public static DesktopManager Instance;
//    public List<App> Apps = new List<App>();

//    public GameObject DesktopAppSample;
//    public Transform AppContent;

//    private void Awake()
//    {
//        Instance = this;
//    }

//    //method to add apps to desktop
//    public void Add(App app)
//    {
//        Apps.Add(app);
//    }

//    //method to remove apps from desktop
//    public void Remove(App app)
//    {
//        Apps.Remove(app);
//    }


//    void start()
//    {
//        GameObject obj = Instantiate(DesktopAppSample, AppContent);
//        var appName = obj.transform.Find(App / AppName).GetComponent<Text>();
//        var appIcon = obj.transform.Find(App / AppIcon).GetComponent<Text>();

//        appName.text = app.appName;
//        appIcon.sprite = app.icon;
//    }
//}
