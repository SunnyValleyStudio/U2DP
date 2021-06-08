using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private HealthUI healthUI;
    private PointsUI pointsUI;

    private void Awake()
    {
        healthUI = GetComponentInChildren<HealthUI>();
        pointsUI = GetComponentInChildren<PointsUI>();
    }

    public void InitializeMaxHealth(int maxHealth)
    {
        healthUI.Initialize(maxHealth);
    }

    public void SetHealth(int currentHealth)
    {
        healthUI.SetHealth(currentHealth);
    }

    public void SetPoints(int currentPoints)
    {
        pointsUI.SetPoints(currentPoints);
    }
}
