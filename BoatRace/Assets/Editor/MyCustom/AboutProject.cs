using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Diagnostics;

public class AboutProject 
{
    [MenuItem("Help/AboutProject/GitHub")]
    static void OpenGithub()
    {
        Process.Start("https://github.com/getker/BoatRace");
    }
    
    [MenuItem("Help/AboutProject/Trello")]
    static void OpenTrello()
    {
        Process.Start("https://trello.com/b/azJXV4Qi/boatrace");
    }
    
    [MenuItem("Help/AboutProject/Wiki")]
    static void OpenWiki()
    {
        Process.Start("https://github.com/getker/BoatRaceWiki/wiki");
    }
}
