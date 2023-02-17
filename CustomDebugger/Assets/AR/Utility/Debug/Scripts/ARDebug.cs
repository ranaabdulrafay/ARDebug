using UnityEditor;
using UnityEngine;
namespace AR.Utility
{
    public static class ARDebug
    {
        public static bool DebugEnabled = true;

        public static void Log(string msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log(msg);
        }
        public static void Log(object msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log(msg);
        }
        public static void Log(object msg,Object context, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log(msg, context);
        }


        public static void Log(string msg, Color color, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log("<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + msg + "</color>");
        }
        public static void Log(object msg, Color color, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log("<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + msg + "</color>");
        }
        public static void Log(object msg, Object context, Color color, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.Log("<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + msg + "</color>", context);
        }


        public static void LogWarning(string msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogWarning(msg);
        }
        public static void LogWarning(object msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogWarning(msg);
        }
        public static void LogWarning(object msg, Object context, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogWarning(msg, context);
        }


        public static void LogError(string msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogError(msg);
        }
        public static void LogError(object msg, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogError(msg);
        }
        public static void LogError(string msg, Object context, bool AlwaysLog = false)
        {
            if (DebugEnabled || AlwaysLog)
                Debug.LogError(msg, context);
        }

#if UNITY_EDITOR
        [MenuItem("ARLog/EnableLog")]
        static void EnableLog()
        {
            DebugEnabled = true;
        }
        [MenuItem("ARLog/DisableLog")]
        static void DisableLog()
        {
            DebugEnabled = false;
        }

        [MenuItem("ARLog/EnableLog", true)]
        static bool ValidateEnableLog()
        {
            return !DebugEnabled;
        }
        [MenuItem("ARLog/DisableLog", true)]
        static bool ValidateDisableLog()
        {
            return DebugEnabled;
        }
#endif
    }
}
