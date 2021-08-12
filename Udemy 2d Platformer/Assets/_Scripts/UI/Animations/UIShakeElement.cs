using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.UI
{
    public class UIShakeElement : MonoBehaviour
    {
        public RectTransform element;
        [Header("Shake animation settings")]
        public float animationTime = 0.5f, shakeStrength = 90, randomness = 90;
        public int vibrato = 90;
        public bool fadeOut = true;
        public float delayBetweenShakes = 3;

        Sequence sequence;

        void Start()
        {
            sequence = DOTween.Sequence()
                .Append(element.DOShakeRotation(animationTime, shakeStrength, vibrato, randomness, fadeOut));
            sequence.SetLoops(-1, LoopType.Restart);
            sequence.AppendInterval(delayBetweenShakes);
            sequence.Play();
        }

        private void OnDestroy()
        {
            sequence.Kill();
        }
    }
}