using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatformChecker : MonoBehaviour
{
    private string _namePlatform;

    public Action<string> OnShowPlatform;


    private void Start()
    {
        CheckPlatform();
    }

    private void CheckPlatform()
    {

#if UNITY_WEBGL
            // Определяем, мобильное это устройство или десктоп
            if (IsMobile())
            {
                Debug.Log("Платформа: Mobile");
                _namePlatform= "Платформа: Mobile";
            }
            else
            {
                Debug.Log("Платформа: Desktop");
                _namePlatform= "Платформа: Desktop";
            }
#else
        Debug.Log("Не WebGL платформа");
        _namePlatform = "Не WebGL платформа";
#endif
        OnShowPlatform?.Invoke(_namePlatform);
    }

    private bool IsMobile()
    {

        return (Application.platform == RuntimePlatform.IPhonePlayer ||
                Application.platform == RuntimePlatform.Android);
    }
}
