# BoatRace
Boat Race : A multiplayer game. （一个以船为主题的多人在线竞速游戏，涉及技术有socket、异步、多路复用，RSA加密，AES加密，状态同步、帧同步、MongoDB数据库，热更新等）。

#### 软件介绍

客户端：2021.3.18f1 LTS, Released: 9 August 2022

服务器 : CSharp, Visual Studio 2019

数据库：[Database Deployments | Cloud: MongoDB Cloud](https://cloud.mongodb.com/v2/62faf79583e7ed69c06a4528#clusters)

看板：[BoatRace | Trello](https://trello.com/b/azJXV4Qi/boatrace)

### 第三方插件

Editor Coroutines : Editor下的协程

UILocalization ： UI翻译

RemoteDebugger：RemoteDebugger

[Mobile Notifications](https://docs.unity3d.com/Packages/com.unity.mobile.notifications@2.0/manual/index.html)

[UnityCsReference](https://github.com/Unity-Technologies/UnityCsReference)

[tolua](https://github.com/topameng/tolua/tree/luac5.3)

[Unity-Finder](https://github.com/litefeel/Unity-Finder)


#### To Do Add

[Easy Save - The Complete Save Data & Serialization System | 实用工具 工具 | Unity Asset Store](https://assetstore.unity.com/packages/tools/utilities/easy-save-the-complete-save-data-serialization-system-768#releases)

### Other

Unity隐藏指定的黄色warning警告 
```csharp
#pragma warning disable 0618
```


#### About

[**C#中AES加密的实现_林新发的博客-CSDN博客_c#中aes加密**](https://blog.csdn.net/linxinfa/article/details/89970196)

[使用Rider断点调试lua代码_无名小花emm的博客-CSDN博客_rider 调试lua](https://blog.csdn.net/qq_44625873/article/details/123901004)

[利用反射查探UnityEditor](https://www.jianshu.com/p/2aa309aa7fec)

[雨松MOMO](https://www.xuanyusong.com)

[UnityEditor 控制台导出文本](https://blog.csdn.net/wayneviger/article/details/80873114)

[《Unity 3D游戏客户端基础框架》tolua 框架接入](https://blog.csdn.net/linshuhe1/article/details/77816480)

[IllegalWordsDetection](https://github.com/NewbieGameCoder/IllegalWordsDetection)

### 工具

[ILSpy](https://github.com/icsharpcode/ILSpy)

#### Unity特殊文件夹
1.隐藏文件夹（以.开头的文件会被忽略）

2.Standard Assets（这个文件夹中的脚本最先被编译）

3.Pro Standard Assets（与Standard Assets，文件是给Pro版本的Unity使用的）

4.Editor（允许其中的脚本访问Unity Editor的API，如果脚本中使用了在UnityEditor命名空间中的类或方法必须放在名为Editor的文件夹中 Editor中的脚本不会在build时被包含）

5.Plugins(用来放native插件 只能是Assets文件夹的直接子目录)

6.Resources（允许在脚本中通过文件路径和名称来访问资源）只读

7.Editor Default Resources（为Editor脚本使用的文件夹）

8.Gizmos（存放Gizmos.DrawIcon方法使用的贴图，图标资源，在此文件夹中的贴图资源可以直接通过名称使用）

9.WebPlayerTemplates（用来替换web build的默认网页，这个文件夹中的脚本不会被编译，必须作为Assets文件夹的直接子目录）

10.StremingAssets（这里的文件会被拷贝到build文件夹中，不会修改，路径会因平台而有差异，但都可以通过Application.streamingAssetsPath来访问）只读

