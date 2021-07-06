using System;
using System.Collections;
using UnityEngine;

namespace SVS.AI
{
    public class AIEndPlatformDetector : MonoBehaviour
    {
        public BoxCollider2D detectorCollider;

        public LayerMask groundMask;
        public float groundRaycastLength = 2;

        [Range(0, 1)]
        public float groundRaycastDelay = 0.1f;

        public bool PathBlocked { get; private set; }

        public event Action OnPathBlocked;

        [Header("Gizmo Parameters")]
        public Color colliderColor = Color.magenta;
        public Color groundRaycastColor = Color.blue;
        public bool ShowGizmos = true;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnPathBlocked?.Invoke();
        }

        private void Start()
        {
            StartCoroutine(CheckGroundCoroutine());
        }

        IEnumerator CheckGroundCoroutine()
        {
            yield return new WaitForSeconds(groundRaycastDelay);
            var hit = Physics2D.Raycast(detectorCollider.bounds.center, Vector2.down, groundRaycastLength, groundMask);
            if (hit.collider == null)
            {
                OnPathBlocked?.Invoke();

            }
            PathBlocked = hit.collider == null;
            StartCoroutine(CheckGroundCoroutine());
        }

        private void OnDrawGizmos()
        {
            if (ShowGizmos && detectorCollider != null)
            {
                Gizmos.color = groundRaycastColor;
                Gizmos.DrawRay(detectorCollider.bounds.center, Vector2.down * groundRaycastLength);
                Gizmos.color = colliderColor;
                Gizmos.DrawCube(detectorCollider.bounds.center, detectorCollider.bounds.size);
            }
        }
    }
}