using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PointsUI : MonoBehaviour
{
    private TextMeshProUGUI pointsText;

    public UnityEvent OnTextChange;

    private void Awake()
    {
        pointsText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetPoints(int val)
    {
        pointsText.SetText(val.ToString());
        OnTextChange?.Invoke();
    }
}
