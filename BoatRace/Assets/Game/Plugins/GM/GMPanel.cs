using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class GMPanel : MonoBehaviour
{
    private Toggle toggle;
    private GameObject menu;
    private Text ipText;
    
    void Awake()
    {
        menu = transform.Find("Menu").gameObject;
        ipText = menu.transform.Find("Grid/IP/Text").GetComponent<Text>();
        
        toggle = transform.Find("Toggle").GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleChanged);
        OnToggleChanged(toggle.isOn);
    }

    private void OnToggleChanged(bool isOn)
    {
        menu.SetActive(isOn);
        if (isOn) {
            RefreshMenu();
        }
    }
    
    void RefreshMenu()
    {
        ipText.text = GetAddressIP();
        
    }
    
    private string GetAddressIP()
    {
        var addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
        foreach (var ipAddress in addressList)
        {
            if (ipAddress.AddressFamily.ToString() == "InterNetwork")
            {
                return ipAddress.ToString();
            }
        }

        return null;
    }
}
