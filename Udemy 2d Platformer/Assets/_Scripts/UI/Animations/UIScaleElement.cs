using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.UI
{
    public class UIScaleElement : MonoBehaviour
    {
        private Sequence sequence;

        [SerializeField]
        private RectTransform element;
        [SerializeField]
        private float animationEndScale;
        [SerializeField]
        private float animationTime;
        private float baseScaleValue;
        private Vector3 baseScale, endScale;
        [SerializeField]
        private bool playConstantly = false;

        private void Start()
        {
            baseScale = element.localScale;
            endScale = Vector3.one * animationEndScale;

            if (playConstantly)
            {
                sequence = DOTween.Sequence()
                    .Append(element.DOScale(baseScale, animationTime))
                    .Append(element.DOScale(endScale, animationTime));
                sequence.SetLoops(-1, LoopType.Yoyo);
                sequence.Play();
            }
        }

        public void PlayAnimation()
        {
            StopAllCoroutines();
            element.localScale = baseScale;
            StartCoroutine(ScaleImage(true));
        }
        
        public IEnumerator ScaleImage(bool scaleUp)
        {
            float time = 0;
            while (time < animationTime)
            {
                time += Time.deltaTime;
                float value = (time / animationTime);
                Vector3 currentScale;
                if (scaleUp)
                {
                    currentScale = baseScale + value * (endScale - baseScale);
                }
                else
                {
                    currentScale = endScale - value * (endScale - baseScale);
                }
                element.localScale = currentScale;
                yield return null;
            }

            element.localScale = scaleUp ? endScale : baseScale;
            if (playConstantly || scaleUp == true)
                StartCoroutine(ScaleImage(!scaleUp));
        }

        private void OnDestroy()
        {
            if (sequence != null)
                sequence.Kill();
        }
    }
}