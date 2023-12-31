﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_WrapModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.WrapMode));
		L.RegVar("Once", new LuaCSFunction(get_Once), null);
		L.RegVar("Loop", new LuaCSFunction(get_Loop), null);
		L.RegVar("PingPong", new LuaCSFunction(get_PingPong), null);
		L.RegVar("Default", new LuaCSFunction(get_Default), null);
		L.RegVar("ClampForever", new LuaCSFunction(get_ClampForever), null);
		L.RegVar("Clamp", new LuaCSFunction(get_Clamp), null);
		L.RegFunction("IntToEnum", new LuaCSFunction(IntToEnum));
		L.EndEnum();
		TypeTraits<UnityEngine.WrapMode>.Check = CheckType;
		StackTraits<UnityEngine.WrapMode>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.WrapMode arg)
	{
		ToLua.Push(L, arg);
	}

	static Type TypeOf_UnityEngine_WrapMode = typeof(UnityEngine.WrapMode);

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(TypeOf_UnityEngine_WrapMode, L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Once(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Once);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loop(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Loop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PingPong(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.PingPong);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Default(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ClampForever(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.ClampForever);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Clamp(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Clamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
		UnityEngine.WrapMode o = (UnityEngine.WrapMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

