﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_SpaceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.Space));
		L.RegVar("World", new LuaCSFunction(get_World), null);
		L.RegVar("Self", new LuaCSFunction(get_Self), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<UnityEngine.Space>.Check = CheckType;
		StackTraits<UnityEngine.Space>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.Space arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_UnityEngine_Space = typeof(UnityEngine.Space);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_UnityEngine_Space, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_World(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Space.World);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Self(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Space.Self);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		UnityEngine.Space o = (UnityEngine.Space)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

