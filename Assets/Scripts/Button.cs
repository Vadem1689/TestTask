using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private LoadSprites _loadSprites;

    [SerializeField] private float _fadeDuration = 1f;
    [SerializeField] private Image _buttonImage;

    private bool _isAnimating;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        if (_buttonImage == null)
        {
            _buttonImage = GetComponent<Image>();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        if (!_isAnimating)
        {
            _animator.SetBool("anim", true);
            _loadSprites.Load();
        }
    }
}
