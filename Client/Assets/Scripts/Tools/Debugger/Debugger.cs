using BoatRace.Core.Utility;

namespace BoatRace.Tools.Debugger
{
    public static class Debugger
    {
        static Debugger()
        {
            for (int size = 24; size < 70; ++size)
                StringPool.PreAlloc(size, 2);
        }
        
        // [Conditional("ENABLE_DEBUG_LOG")]
        // public static void Log(string message)
        // {
        //     Debug.Log(message);
        // }
        
        
        
        public static bool useLog = true;
        public static string threadStack = string.Empty;
        
        // public static ILogger logger = (ILogger) null;
        
        // // private static CString sb = new CString(256);
        // private static StringBuilder sb = new StringBuilder(256);
        //
        
        // private static string GetLogFormat(string str)
        // {
        //     DateTime now = DateTime.Now;
        //     Debugger.sb.Clear();
        //     Debugger.sb.Append(ConstStringTable.GetTimeIntern(now.Hour)).Append(":")
        //         .Append(ConstStringTable.GetTimeIntern(now.Minute)).Append(":")
        //         .Append(ConstStringTable.GetTimeIntern(now.Second)).Append(".").Append(now.Millisecond).Append("-")
        //         .Append(Time.frameCount % 999).Append(": ").Append(str);
        //     // string str1 = StringPool.Alloc(Debugger.sb.Length);
        //     // Debugger.sb.CopyToString(str1);
        //     // Debugger.sb.CopyTo(str1);
        //     string str1 = sb.ToString();
        //     return str1;
        // }
        //
        // public static void Log(string str)
        // {
        //     str = Debugger.GetLogFormat(str);
        //     if (Debugger.useLog)
        //         Debug.Log((object) str);
        //     else if (Debugger.logger != null)
        //         Debugger.logger.Log(LogType.Log, string.Empty, str);
        //     StringPool.Collect(str);
        // }
        //
        // public static void Log(object message) => Debugger.Log(message.ToString());
        //
        // public static void Log(string str, object arg0) => Debugger.Log(string.Format(str, arg0));
        //
        // public static void Log(string str, object arg0, object arg1) => Debugger.Log(string.Format(str, arg0, arg1));
        //
        // public static void Log(string str, object arg0, object arg1, object arg2) =>
        //     Debugger.Log(string.Format(str, arg0, arg1, arg2));
        //
        // public static void Log(string str, params object[] param) => Debugger.Log(string.Format(str, param));
        //
        // public static void LogWarning(string str)
        // {
        //     str = Debugger.GetLogFormat(str);
        //     if (Debugger.useLog)
        //         Debug.LogWarning((object) str);
        //     else if (Debugger.logger != null) {
        //         string stackTrace = StackTraceUtility.ExtractStackTrace();
        //         Debugger.logger.Log(str, stackTrace, LogType.Warning);
        //     }
        //
        //     StringPool.Collect(str);
        // }
        //
        // public static void LogWarning(object message) => Debugger.LogWarning(message.ToString());
        //
        // public static void LogWarning(string str, object arg0) => Debugger.LogWarning(string.Format(str, arg0));
        //
        // public static void LogWarning(string str, object arg0, object arg1) =>
        //     Debugger.LogWarning(string.Format(str, arg0, arg1));
        //
        // public static void LogWarning(string str, object arg0, object arg1, object arg2) =>
        //     Debugger.LogWarning(string.Format(str, arg0, arg1, arg2));
        //
        // public static void LogWarning(string str, params object[] param) =>
        //     Debugger.LogWarning(string.Format(str, param));
        //
        // public static void LogError(string str)
        // {
        //     str = Debugger.GetLogFormat(str);
        //     if (Debugger.useLog)
        //         Debug.LogError((object) str);
        //     else if (Debugger.logger != null) {
        //         // string stackTrace = StackTraceUtility.ExtractStackTrace();
        //         // Debugger.logger.Log(str, stackTrace, LogType.Error);
        //     }
        //
        //     StringPool.Collect(str);
        // }
        //
        // public static void LogError(object message) => Debugger.LogError(message.ToString());
        //
        // public static void LogError(string str, object arg0) => Debugger.LogError(string.Format(str, arg0));
        //
        // public static void LogError(string str, object arg0, object arg1) =>
        //     Debugger.LogError(string.Format(str, arg0, arg1));
        //
        // public static void LogError(string str, object arg0, object arg1, object arg2) =>
        //     Debugger.LogError(string.Format(str, arg0, arg1, arg2));
        //
        // public static void LogError(string str, params object[] param) => Debugger.LogError(string.Format(str, param));
        //
        // public static void LogException(Exception e)
        // {
        //     Debugger.threadStack = e.StackTrace;
        //     string logFormat = Debugger.GetLogFormat(e.Message);
        //     if (Debugger.useLog)
        //         Debug.LogError((object) logFormat);
        //     else if (Debugger.logger != null)
        //         Debugger.logger.Log(LogType.Exception, logFormat, Debugger.threadStack);
        //     // Debugger.logger.Log(logFormat, Debugger.threadStack, LogType.Exception);
        //     StringPool.Collect(logFormat);
        // }
        //
        // public static void LogException(string str, Exception e)
        // {
        //     Debugger.threadStack = e.StackTrace;
        //     str = Debugger.GetLogFormat(str + e.Message);
        //     if (Debugger.useLog)
        //         Debug.LogError((object) str);
        //     else if (Debugger.logger != null)
        //         Debugger.logger.Log(str, Debugger.threadStack, LogType.Exception);
        //     StringPool.Collect(str);
        // }
    }
}