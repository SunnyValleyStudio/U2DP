using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SVS.UI
{
    public class UIScaleTextFont : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI text;
        [SerializeField]
        private float fontAnimationSize = 80;
        [SerializeField]
        private float fontAnimationTime = 0.3f;
        private float baseFontSize;

        private void Awake()
        {
            baseFontSize = text.fontSize;
        }

        public void PlayAnimation()
        {
            StopAllCoroutines();
            text.fontSize = baseFontSize;
            StartCoroutine(AnimateText(fontAnimationTime));
        }

        private IEnumerator AnimateText(float animationTime)
        {
            float time = 0;

            float delta = fontAnimationSize - baseFontSize;
            while (time < animationTime)
            {
                time += Time.deltaTime;
                float newFontSize = baseFontSize + delta * (time / animationTime);
                text.fontSize = newFontSize;
                yield return null;
            }
            text.fontSize = baseFontSize;
        }
    }
}