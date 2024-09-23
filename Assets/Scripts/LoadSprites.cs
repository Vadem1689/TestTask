using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadSprites : MonoBehaviour 
{
    [SerializeField] private SpriteRenderer[] _spriteRenderer;
    [SerializeField] private string[] _strings;

    public void Load()
    {
        for (int i = 0; i < _spriteRenderer.Length; i++)
        {
            StartCoroutine(LoadSprite(_spriteRenderer[i], i));
        }
    }

    private IEnumerator LoadSprite(SpriteRenderer spriteRenderer, int number)
    {
        var task = Addressables.LoadAssetAsync<Sprite>(_strings[number]);
        yield return task;
        spriteRenderer.sprite = task.Result;
        Addressables.ReleaseInstance(task);
    }

}
