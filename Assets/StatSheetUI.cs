using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatSheetUI : MonoBehaviour
{
    private StatUI[] statUIs;
    private void Awake()
    {
        statUIs = GetComponentsInChildren<StatUI>();
        var playerStats = FindObjectOfType<PlayerStats>();
        if (playerStats != null)
        {
            playerStats.statSheetUI = this;
        }

    }
    public void UpdateStatSheet()
    {
        foreach (var statUI in statUIs)
        {
            statUI.GetCurrentStats();
        }
    }
}
