using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public Transform slotParent;
    public Inventory inventory;
    private InventorySlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        slots = slotParent.GetComponentsInChildren<InventorySlot>();
        UpdateUI();

        inventory.onInventoryChange += UpdateUI;
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");
        for (int i = 0; i < Inventory.INVENTORY_SIZE; i++)
        {
            InventorySlot slot = slots[i];
            Item item = inventory.items[i];

            if (i == inventory.selected)
            {
                slot.SetSelected(true);
            } else
            {
                slot.SetSelected(false);
            }
            if (item != null)
            {
                slot.SetItem(item, inventory.quantity[i]);
            } else
            {
                slot.ClearSlot();
            }
        }
    }


}
