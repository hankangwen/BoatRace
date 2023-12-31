﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ApplicationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Application");
		L.RegFunction("Quit", new LuaCSFunction(Quit));
		L.RegFunction("Unload", new LuaCSFunction(Unload));
		L.RegFunction("CanStreamedLevelBeLoaded", new LuaCSFunction(CanStreamedLevelBeLoaded));
		L.RegFunction("IsPlaying", new LuaCSFunction(IsPlaying));
		L.RegFunction("GetBuildTags", new LuaCSFunction(GetBuildTags));
		L.RegFunction("SetBuildTags", new LuaCSFunction(SetBuildTags));
		L.RegFunction("HasProLicense", new LuaCSFunction(HasProLicense));
		L.RegFunction("RequestAdvertisingIdentifierAsync", new LuaCSFunction(RequestAdvertisingIdentifierAsync));
		L.RegFunction("OpenURL", new LuaCSFunction(OpenURL));
		L.RegFunction("GetStackTraceLogType", new LuaCSFunction(GetStackTraceLogType));
		L.RegFunction("SetStackTraceLogType", new LuaCSFunction(SetStackTraceLogType));
		L.RegFunction("RequestUserAuthorization", new LuaCSFunction(RequestUserAuthorization));
		L.RegFunction("HasUserAuthorization", new LuaCSFunction(HasUserAuthorization));
		L.RegVar("isPlaying", new LuaCSFunction(get_isPlaying), null);
		L.RegVar("isFocused", new LuaCSFunction(get_isFocused), null);
		L.RegVar("buildGUID", new LuaCSFunction(get_buildGUID), null);
		L.RegVar("runInBackground", new LuaCSFunction(get_runInBackground), new LuaCSFunction(set_runInBackground));
		L.RegVar("isBatchMode", new LuaCSFunction(get_isBatchMode), null);
		L.RegVar("dataPath", new LuaCSFunction(get_dataPath), null);
		L.RegVar("streamingAssetsPath", new LuaCSFunction(get_streamingAssetsPath), null);
		L.RegVar("persistentDataPath", new LuaCSFunction(get_persistentDataPath), null);
		L.RegVar("temporaryCachePath", new LuaCSFunction(get_temporaryCachePath), null);
		L.RegVar("absoluteURL", new LuaCSFunction(get_absoluteURL), null);
		L.RegVar("unityVersion", new LuaCSFunction(get_unityVersion), null);
		L.RegVar("version", new LuaCSFunction(get_version), null);
		L.RegVar("installerName", new LuaCSFunction(get_installerName), null);
		L.RegVar("identifier", new LuaCSFunction(get_identifier), null);
		L.RegVar("installMode", new LuaCSFunction(get_installMode), null);
		L.RegVar("sandboxType", new LuaCSFunction(get_sandboxType), null);
		L.RegVar("productName", new LuaCSFunction(get_productName), null);
		L.RegVar("companyName", new LuaCSFunction(get_companyName), null);
		L.RegVar("cloudProjectId", new LuaCSFunction(get_cloudProjectId), null);
		L.RegVar("targetFrameRate", new LuaCSFunction(get_targetFrameRate), new LuaCSFunction(set_targetFrameRate));
		L.RegVar("consoleLogPath", new LuaCSFunction(get_consoleLogPath), null);
		L.RegVar("backgroundLoadingPriority", new LuaCSFunction(get_backgroundLoadingPriority), new LuaCSFunction(set_backgroundLoadingPriority));
		L.RegVar("genuine", new LuaCSFunction(get_genuine), null);
		L.RegVar("genuineCheckAvailable", new LuaCSFunction(get_genuineCheckAvailable), null);
		L.RegVar("platform", new LuaCSFunction(get_platform), null);
		L.RegVar("isMobilePlatform", new LuaCSFunction(get_isMobilePlatform), null);
		L.RegVar("isConsolePlatform", new LuaCSFunction(get_isConsolePlatform), null);
		L.RegVar("systemLanguage", new LuaCSFunction(get_systemLanguage), null);
		L.RegVar("internetReachability", new LuaCSFunction(get_internetReachability), null);
		L.RegVar("isEditor", new LuaCSFunction(get_isEditor), null);
		L.RegVar("lowMemory", new LuaCSFunction(get_lowMemory), new LuaCSFunction(set_lowMemory));
		L.RegVar("logMessageReceived", new LuaCSFunction(get_logMessageReceived), new LuaCSFunction(set_logMessageReceived));
		L.RegVar("logMessageReceivedThreaded", new LuaCSFunction(get_logMessageReceivedThreaded), new LuaCSFunction(set_logMessageReceivedThreaded));
		L.RegVar("onBeforeRender", new LuaCSFunction(get_onBeforeRender), new LuaCSFunction(set_onBeforeRender));
		L.RegVar("focusChanged", new LuaCSFunction(get_focusChanged), new LuaCSFunction(set_focusChanged));
		L.RegVar("deepLinkActivated", new LuaCSFunction(get_deepLinkActivated), new LuaCSFunction(set_deepLinkActivated));
		L.RegVar("wantsToQuit", new LuaCSFunction(get_wantsToQuit), new LuaCSFunction(set_wantsToQuit));
		L.RegVar("quitting", new LuaCSFunction(get_quitting), new LuaCSFunction(set_quitting));
		L.RegVar("unloading", new LuaCSFunction(get_unloading), new LuaCSFunction(set_unloading));
		L.RegFunction("AdvertisingIdentifierCallback", new LuaCSFunction(UnityEngine_Application_AdvertisingIdentifierCallback));
		L.RegFunction("LogCallback", new LuaCSFunction(UnityEngine_Application_LogCallback));
		L.RegFunction("LowMemoryCallback", new LuaCSFunction(UnityEngine_Application_LowMemoryCallback));
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Quit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Application.Quit();
				return 0;
			}
			else if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				UnityEngine.Application.Quit(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Application.Quit");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Application.Unload();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanStreamedLevelBeLoaded(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
				bool o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Application.CanStreamedLevelBeLoaded");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsPlaying(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			bool o = UnityEngine.Application.IsPlaying(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBuildTags(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string[] o = UnityEngine.Application.GetBuildTags();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBuildTags(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string[] arg0 = ToLua.CheckStringArray(L, 1);
			UnityEngine.Application.SetBuildTags(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasProLicense(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = UnityEngine.Application.HasProLicense();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RequestAdvertisingIdentifierAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Application.AdvertisingIdentifierCallback arg0 = (UnityEngine.Application.AdvertisingIdentifierCallback)ToLua.CheckDelegate<UnityEngine.Application.AdvertisingIdentifierCallback>(L, 1);
			bool o = UnityEngine.Application.RequestAdvertisingIdentifierAsync(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenURL(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Application.OpenURL(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStackTraceLogType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.LogType arg0 = (UnityEngine.LogType)ToLua.CheckObject(L, 1, TypeTraits<UnityEngine.LogType>.type);
			UnityEngine.StackTraceLogType o = UnityEngine.Application.GetStackTraceLogType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetStackTraceLogType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.LogType arg0 = (UnityEngine.LogType)ToLua.CheckObject(L, 1, TypeTraits<UnityEngine.LogType>.type);
			UnityEngine.StackTraceLogType arg1 = (UnityEngine.StackTraceLogType)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.StackTraceLogType>.type);
			UnityEngine.Application.SetStackTraceLogType(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RequestUserAuthorization(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, TypeTraits<UnityEngine.UserAuthorization>.type);
			UnityEngine.AsyncOperation o = UnityEngine.Application.RequestUserAuthorization(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasUserAuthorization(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, TypeTraits<UnityEngine.UserAuthorization>.type);
			bool o = UnityEngine.Application.HasUserAuthorization(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isPlaying);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFocused(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isFocused);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_buildGUID(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.buildGUID);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_runInBackground(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.runInBackground);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isBatchMode(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isBatchMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.dataPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.streamingAssetsPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_persistentDataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.persistentDataPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_temporaryCachePath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.temporaryCachePath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_absoluteURL(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.absoluteURL);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unityVersion(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.unityVersion);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_version(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.version);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_installerName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.installerName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_identifier(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.identifier);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_installMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.installMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sandboxType(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.sandboxType);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_productName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.productName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_companyName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.companyName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cloudProjectId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.cloudProjectId);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetFrameRate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Application.targetFrameRate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_consoleLogPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Application.consoleLogPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_backgroundLoadingPriority(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.backgroundLoadingPriority);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuine(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuine);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuineCheckAvailable(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuineCheckAvailable);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_platform(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.platform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMobilePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isMobilePlatform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isConsolePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isConsolePlatform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemLanguage(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.systemLanguage);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_internetReachability(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Application.internetReachability);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isEditor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Application.isEditor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lowMemory(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Application.LowMemoryCallback)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceived(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Application.LogCallback)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceivedThreaded(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Application.LogCallback)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBeforeRender(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(UnityEngine.Events.UnityAction)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_focusChanged(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<bool>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deepLinkActivated(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<string>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wantsToQuit(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Func<bool>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_quitting(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unloading(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_runInBackground(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Application.runInBackground = arg0;
			UnityEngine.Application.runInBackground = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetFrameRate(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.Application.targetFrameRate = arg0;
			UnityEngine.Application.targetFrameRate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_backgroundLoadingPriority(IntPtr L)
	{
		try
		{
			UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)ToLua.CheckObject(L, 2, TypeTraits<UnityEngine.ThreadPriority>.type);
			UnityEngine.Application.backgroundLoadingPriority = arg0;
			UnityEngine.Application.backgroundLoadingPriority = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lowMemory(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.lowMemory' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Application.LowMemoryCallback ev = (UnityEngine.Application.LowMemoryCallback)arg0.func;
				UnityEngine.Application.lowMemory += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Application.LowMemoryCallback ev = (UnityEngine.Application.LowMemoryCallback)arg0.func;
				UnityEngine.Application.lowMemory -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceived(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.logMessageReceived' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceived += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceived -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceivedThreaded(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.logMessageReceivedThreaded' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceivedThreaded += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)arg0.func;
				UnityEngine.Application.logMessageReceivedThreaded -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBeforeRender(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.onBeforeRender' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				UnityEngine.Events.UnityAction ev = (UnityEngine.Events.UnityAction)arg0.func;
				UnityEngine.Application.onBeforeRender += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				UnityEngine.Events.UnityAction ev = (UnityEngine.Events.UnityAction)arg0.func;
				UnityEngine.Application.onBeforeRender -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_focusChanged(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.focusChanged' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<bool> ev = (System.Action<bool>)arg0.func;
				UnityEngine.Application.focusChanged += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<bool> ev = (System.Action<bool>)arg0.func;
				UnityEngine.Application.focusChanged -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_deepLinkActivated(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.deepLinkActivated' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<string> ev = (System.Action<string>)arg0.func;
				UnityEngine.Application.deepLinkActivated += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<string> ev = (System.Action<string>)arg0.func;
				UnityEngine.Application.deepLinkActivated -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wantsToQuit(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.wantsToQuit' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Func<bool> ev = (System.Func<bool>)arg0.func;
				UnityEngine.Application.wantsToQuit += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Func<bool> ev = (System.Func<bool>)arg0.func;
				UnityEngine.Application.wantsToQuit -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_quitting(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.quitting' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				UnityEngine.Application.quitting += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				UnityEngine.Application.quitting -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_unloading(IntPtr L)
	{
		try
		{
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'UnityEngine.Application.unloading' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action ev = (System.Action)arg0.func;
				UnityEngine.Application.unloading += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action ev = (System.Action)arg0.func;
				UnityEngine.Application.unloading -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func);
				ToLua.Push(L, arg1);
				func.Dispose();
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.AdvertisingIdentifierCallback>.Create(func, self);
				ToLua.Push(L, arg1);
				func.Dispose();
				self.Dispose();
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func);
				ToLua.Push(L, arg1);
				func.Dispose();
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LogCallback>.Create(func, self);
				ToLua.Push(L, arg1);
				func.Dispose();
				self.Dispose();
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LowMemoryCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LowMemoryCallback>.Create(func);
				ToLua.Push(L, arg1);
				func.Dispose();
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Application.LowMemoryCallback>.Create(func, self);
				ToLua.Push(L, arg1);
				func.Dispose();
				self.Dispose();
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

