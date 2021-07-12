using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponSystem;

namespace SVS.Feedback
{
    public class HittableTempImmortality : MonoBehaviour, IHittable
    {
        public Collider2D[] colliders = new Collider2D[0];
        public float immortalityTime = 1;

        public SpriteRenderer spriteRenderer;
        public float flashDelay = 0.1f;
        [Range(0, 1)]
        public float flashAlpha = 0.5f;


        [Header("For debug purposes")]
        public bool isImmortal = false;

        private void Awake()
        {
            if (colliders.Length == 0)
                colliders = GetComponents<Collider2D>();
        }

        public void GetHit(GameObject gameObject, int weaponDamage)
        {
            if (this.enabled == false)
                return;
            ToggleColliders(false);
            StartCoroutine(ResetColliders());
            StartCoroutine(Flash(flashAlpha));
        }

        private void ToggleColliders(bool val)
        {
            isImmortal = !val;
            foreach (var collider in colliders)
            {
                collider.enabled = val;
            }
        }

        IEnumerator ResetColliders()
        {
            yield return new WaitForSeconds(immortalityTime);
            StopAllCoroutines();
            ToggleColliders(true);
            ChangeSpriteRendererColorAlpha(1);
        }

        private void ChangeSpriteRendererColorAlpha(float alpha)
        {
            Color c = spriteRenderer.color;
            c.a = alpha;
            spriteRenderer.color = c;
        }

        IEnumerator Flash(float alpha)
        {
            alpha = Mathf.Clamp01(alpha);
            ChangeSpriteRendererColorAlpha(alpha);
            yield return new WaitForSeconds(flashDelay);
            StartCoroutine(Flash(alpha < 1 ? 1 : flashAlpha));

        }
    }
}