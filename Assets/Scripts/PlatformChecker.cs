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
            // ����������, ��������� ��� ���������� ��� �������
            if (IsMobile())
            {
                Debug.Log("���������: Mobile");
                _namePlatform= "���������: Mobile";
            }
            else
            {
                Debug.Log("���������: Desktop");
                _namePlatform= "���������: Desktop";
            }
#else
        Debug.Log("�� WebGL ���������");
        _namePlatform = "�� WebGL ���������";
#endif
        OnShowPlatform?.Invoke(_namePlatform);
    }

    private bool IsMobile()
    {

        return (Application.platform == RuntimePlatform.IPhonePlayer ||
                Application.platform == RuntimePlatform.Android);
    }
}
