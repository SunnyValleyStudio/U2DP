using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.Platforms
{
    public class PlatformColliderAdjuster : MonoBehaviour
    {
        [SerializeField]
        private BoxCollider2D platformCollider;
        [SerializeField]
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            platformCollider.size
                = new Vector2(spriteRenderer.size.x, platformCollider.size.y);
            platformCollider.offset = 
                new Vector2(0, spriteRenderer.bounds.size.y / 2f - platformCollider.size.y / 2f);

        }
    }
}