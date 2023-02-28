namespace Events 
{
    public static class GameEvents 
    {
        public delegate void SendAppData (string appName);
        public static SendAppData onSendAppDataEvent;
    }
}

