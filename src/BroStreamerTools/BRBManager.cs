using System;
using BroStreamerTools.Logging;

namespace BroStreamerTools
{
    public static class BRBManager
    {
        public static void Start(object cph, int duration)
        {
            BroLogger.Info($"BRB started: {duration} minutes");
            Invoke(cph, "SetGlobalVar", "BRBDuration", duration, true);
            Invoke(cph, "SetGlobalVar", "BRBStartTime", DateTime.Now, true);
        }

        private static void Invoke(object cph, string method, params object[] args)
        {
            cph.GetType().GetMethod(method).Invoke(cph, args);
        }
    }
}
