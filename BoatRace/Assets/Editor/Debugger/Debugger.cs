// using System;
// using System.Diagnostics;
// using System.Text;
// using BoatRace.Core.Utility;
// using UnityEngine;
// using Debug = UnityEngine.Debug;
//
// namespace BoatRace.Tools.Debugger
// {
//     public static class Debugger
//     {
//         static Debugger()
//         {
//             for (int size = 24; size < 70; ++size)
//                 StringPool.PreAlloc(size, 2);
//         }
//         
//         private static StringBuilder sb = new StringBuilder(256);
//
//         private static string GetLogFormat(string str)
//         {
//             DateTime now = DateTime.Now;
//             sb.Clear();
//             sb.Append(ConstStringTable.GetTimeIntern(now.Hour)).Append(":")
//                 .Append(ConstStringTable.GetTimeIntern(now.Minute)).Append(":")
//                 .Append(ConstStringTable.GetTimeIntern(now.Second)).Append(".").Append(now.Millisecond).Append("-")
//                 .Append(Time.frameCount % 999).Append(": ").Append(str);
//             string str1 = StringPool.Alloc(Debugger.sb.Length);
//             // string stackTrace = StackTraceUtility.ExtractStackTrace();
//             str1 = sb.ToString();
//             return str1;
//         }
//
//         #region Log
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(string str)
//         {
//             str = Debugger.GetLogFormat(str);
//             Debug.Log((object) str);
//             StringPool.Collect(str);
//         }
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(object message) => Debugger.Log(message.ToString());
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(string str, object arg0) => Debugger.Log(string.Format(str, arg0));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(string str, object arg0, object arg1) => Debugger.Log(string.Format(str, arg0, arg1));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(string str, object arg0, object arg1, object arg2) =>
//             Debugger.Log(string.Format(str, arg0, arg1, arg2));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void Log(string str, params object[] param) => Debugger.Log(string.Format(str, param));
//         
//         #endregion
//         
//         
//         #region LogWarning
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(string str)
//         {
//             str = Debugger.GetLogFormat(str);
//             Debug.LogWarning((object) str);
//             StringPool.Collect(str);
//         }
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(object message) => Debugger.LogWarning(message.ToString());
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(string str, object arg0) => Debugger.LogWarning(string.Format(str, arg0));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(string str, object arg0, object arg1) =>
//             Debugger.LogWarning(string.Format(str, arg0, arg1));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(string str, object arg0, object arg1, object arg2) =>
//             Debugger.LogWarning(string.Format(str, arg0, arg1, arg2));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogWarning(string str, params object[] param) =>
//             Debugger.LogWarning(string.Format(str, param));
//
//         #endregion
//
//         #region LogError
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(string str)
//         {
//             str = Debugger.GetLogFormat(str);
//             Debug.LogError((object) str);
//             StringPool.Collect(str);
//         }
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(object message) => Debugger.LogError(message.ToString());
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(string str, object arg0) => Debugger.LogError(string.Format(str, arg0));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(string str, object arg0, object arg1) =>
//             Debugger.LogError(string.Format(str, arg0, arg1));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(string str, object arg0, object arg1, object arg2) =>
//             Debugger.LogError(string.Format(str, arg0, arg1, arg2));
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogError(string str, params object[] param) => Debugger.LogError(string.Format(str, param));
//         
//         #endregion
//
//         #region LogException
//
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogException(Exception e)
//         {
//             string logFormat = Debugger.GetLogFormat(e.Message);
//             Debug.LogError((object) logFormat);
//             StringPool.Collect(logFormat);
//         }
//         
//         [Conditional("ENABLE_DEBUG_LOG")]
//         public static void LogException(string str, Exception e)
//         {
//             str = Debugger.GetLogFormat(str + e.Message);
//             Debug.LogError((object) str);
//             StringPool.Collect(str);
//         }
//         #endregion
//     }
// }