using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StatUI : MonoBehaviour
{
    public TextMeshProUGUI statName;
    public TextMeshProUGUI statData;
    public enum StatType
    {
        maxHealth,
        range,
        armourClass,
        attackBonus,
        armour,
        damage
    }
    [SerializeField]
    StatType statType;


    private PlayerStats playerStats;
    void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        switch (statType)
        {
            case StatType.maxHealth:
                statName.text = "Max Health";
                statData.text = playerStats.maxHealth.ToString();
                break;
            case StatType.range:
                statName.text = "Range";
                statData.text = playerStats.range.GetValue().ToString();
                break;
            case StatType.armourClass:
                statName.text = "Armour Class";
                statData.text = playerStats.ArmourClass.GetValue().ToString();
                break;
            case StatType.attackBonus:
                statName.text = "Attack Bonus";
                statData.text = playerStats.attackBonus.GetValue().ToString();
                break;
            case StatType.armour:
                statName.text = "Armour";
                statData.text = playerStats.armor.GetValue().ToString();
                break;
            case StatType.damage:
                statName.text = "damage";
                statData.text = playerStats.damage.GetValue().ToString();
                break;
        }

    }

    public void GetCurrentStats()
    {
        switch (statType)
        {
            case StatType.maxHealth:
             
                statData.text = playerStats.maxHealth.ToString();
                break;
            case StatType.range:
               
                statData.text = playerStats.range.GetValue().ToString();
                break;
            case StatType.armourClass:
               
                statData.text = playerStats.ArmourClass.GetValue().ToString();
                break;
            case StatType.attackBonus:
                
                statData.text = playerStats.attackBonus.GetValue().ToString();
                break;
            case StatType.armour:
               
                statData.text = playerStats.armor.GetValue().ToString();
                break;
            case StatType.damage:
               
                statData.text = playerStats.damage.GetValue().ToString();
                break;
        }
    }
}
