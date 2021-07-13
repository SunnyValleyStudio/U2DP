using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.Common
{
    public class StopRb2DMovementUtil : MonoBehaviour
    {
        Rigidbody2D rb2d;

        private void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void StopMovement()
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}