using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentUISlot : MonoBehaviour
{
    // Start is called before the first frame update
    public Image eIcon;
    Item item;
    [SerializeField]
    int slotIndex;
    EquipmentManager equipmentManager;
    public Button removeButton;
    void Start()
    {
        equipmentManager = EquipmentManager.instance;
    }

    public void RemoveItem()
    {
        item = null;
        eIcon.sprite = null;
        eIcon.enabled = false;
        removeButton.interactable = false;
        equipmentManager.Unequip(slotIndex);
        // Update the UI to remove the item
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        eIcon.sprite = item.icon;
        eIcon.enabled = true;
        removeButton.interactable = true;
    }
}
