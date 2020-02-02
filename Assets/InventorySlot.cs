using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    public Text numberOfItem;
    public Image itemImage;
    public Image slotImage;

    public void ClearSlot()
    {
        numberOfItem.enabled = false;
        itemImage.enabled = false;
    }

    public void SetItem(Item item, int quantity)
    {
        itemImage.sprite = item.sprite;
        numberOfItem.text = quantity.ToString();
        if (quantity > 1)
        {
            numberOfItem.enabled = true;
        }
        itemImage.enabled = true;
    }

    public void SetSelected(bool selected)
    {
        if (selected) {
            slotImage.color = new Color(slotImage.color.r, slotImage.color.g, slotImage.color.b, 1f);
        } else
        {
            slotImage.color = new Color(slotImage.color.r, slotImage.color.g, slotImage.color.b, 0.5f);
        }
            
    }
}
