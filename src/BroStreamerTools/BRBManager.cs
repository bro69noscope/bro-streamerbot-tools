using System;

namespace BroStreamerTools
{
    public static class BRBManager
    {
        public static void Start(object cph, int duration)
        {
            LogInfo(cph, $"BRB started: {duration} minutes");
            Invoke(cph, "SetGlobalVar", "BRBDuration", duration, true);
            Invoke(cph, "SetGlobalVar", "BRBStartTime", DateTime.Now, true);
            LogInfo(cph, "BRB globals updated");
        }

        private static void Invoke(object cph, string method, params object[] args)
        {
            cph.GetType().GetMethod(method).Invoke(cph, args);
        }

        private static void LogInfo(object cph, string message)
        {
            Invoke(cph, "LogInfo", message);
        }
    }
}
