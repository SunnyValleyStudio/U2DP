using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LifeElementUI : MonoBehaviour
{
    private Image image;

    public UnityEvent OnSpriteChange;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void SetSprite(Sprite sprite)
    {
        if (image.sprite != sprite)
        {
            OnSpriteChange?.Invoke();
            image.sprite = sprite;
        }

    }
}
