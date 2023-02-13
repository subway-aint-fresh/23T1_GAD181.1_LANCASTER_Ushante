using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu(fileName = "Application", menuName = "App/Addition of App")]

public class App : ScriptableObject
{
    public int id;
    public string appName;
    public int value;
    public Sprite icon;

}
