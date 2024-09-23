using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlatformView : MonoBehaviour
{
    [SerializeField] private PlatformChecker _platformChecker;
    [SerializeField] private TMP_Text _namePlatformText;

    private void OnEnable()
    {
        _platformChecker.OnShowPlatform += ShowPlatform;
    }

    private void OnDisable()
    {
        _platformChecker.OnShowPlatform -= ShowPlatform;
    }

    private void ShowPlatform(string namePlatform)
    {
        _namePlatformText.text = namePlatform;
    }
}
