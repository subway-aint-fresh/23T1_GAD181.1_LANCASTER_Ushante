using Events;
using UnityEngine;

public class AppInfo : MonoBehaviour
{
    public string appName;

    public void SendInfo()
    {
        GameEvents.onSendAppDataEvent?.Invoke(appName);
    }
}
