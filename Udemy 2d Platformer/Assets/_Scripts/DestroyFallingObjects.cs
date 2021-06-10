using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFallingObjects : MonoBehaviour
{
    public LayerMask objectsToDestoryLayerMask;
    public Vector2 size;

    [Header("Gizmo parameters")]
    public Color gizmoColor = Color.red;
    public bool showGizmo = true;

    private void FixedUpdate()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, size, 0, objectsToDestoryLayerMask);
        if(collider != null)
        {
            Agent agent = collider.GetComponent<Agent>();
            if(agent == null)
            {
                Destroy(collider.gameObject);
                return;
            }
            agent.AgentDied();
        }
    }

    private void OnDrawGizmos()
    {
        if (showGizmo)
        {
            Gizmos.color = gizmoColor;
            Gizmos.DrawCube(transform.position, size);
        }
    }
}
