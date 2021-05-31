using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingDetector : MonoBehaviour
{
    public LayerMask climbingLayerMask;

    [SerializeField]
    private bool canClimb;

    public bool CanClimb
    {
        get { return canClimb; }
        private set { canClimb = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LayerMask collisionLayerMask = 1 << collision.gameObject.layer;
        if((collisionLayerMask & climbingLayerMask) != 0)
        {
            CanClimb = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        LayerMask collisionLayerMask = 1 << collision.gameObject.layer;
        if ((collisionLayerMask & climbingLayerMask) != 0)
        {
            CanClimb = false;
        }
    }

}
