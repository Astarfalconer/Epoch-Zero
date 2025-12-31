using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentUI : MonoBehaviour
{
    private EquipmentManager equipmentManager;
    private EquipmentUISlot[] equipmentUISlots;
    public Transform itemsParent;
    // Start is called before the first frame update
    public void Awake()
    {
      equipmentUISlots = itemsParent.GetComponentsInChildren<EquipmentUISlot>(true);
      equipmentManager = EquipmentManager.instance;
      equipmentManager.equipmentUI = this;
        Debug.Log($"[EquipmentUI] Found {equipmentUISlots.Length} EquipmentUISlots under {itemsParent.name}");
    }

    public void UpdateEquipmentUI()
    {
        if (equipmentManager == null || equipmentManager.currentEquipment == null)
        {
            Debug.LogWarning("[EquipmentUI] No equipmentManager or currentEquipment!");
            return;
        }
        for (int i = 0; i < equipmentUISlots.Length; i++)
        {
            Item item = equipmentManager.currentEquipment[i];
            Debug.Log($"[EquipmentUI] Slot {i} has: {(item != null ? item.name : "null")}");

        

            if (item != null)
            {
                equipmentUISlots[i].AddItem(item);
            }
            else
            {
                equipmentUISlots[i].RemoveItem();
            }
        }
    }

}
