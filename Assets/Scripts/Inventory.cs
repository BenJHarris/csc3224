using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    public static int INVENTORY_SIZE = 10;

    public ItemDatabase itemDatabase;

    public delegate void OnInventoryChange();
    public OnInventoryChange onInventoryChange;

    public Item[] items = new Item[INVENTORY_SIZE];
    public int[] quantity = new int[INVENTORY_SIZE];
    public int selected = 0;

    public bool AddItem(Item item)
    {
        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            if (items[i] == item)
            {
                quantity[i]++;
                onInventoryChange.Invoke();
                return true;
            }
        }

        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                quantity[i] = 1;
                onInventoryChange.Invoke();
                return true;
            }
        }

        return false;
    }

    public Item GetSelectedItem()
    {
        return items[selected];
    }

    public void IncreaseSelected()
    {
        selected = (selected + 1) % INVENTORY_SIZE;
        onInventoryChange.Invoke();
    }

    public void DecreaseSelected()
    {
        if (selected == 0)
        {
            selected = INVENTORY_SIZE - 1;
        } else
        {
            selected--;
        }
        onInventoryChange.Invoke();
    }

    public void SetSelected(int slot)
    {
        selected = Mathf.Abs(slot) % INVENTORY_SIZE;
        onInventoryChange.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown("0"))
        {
            SetSelected(9);
        } else if (Input.GetKeyDown("1"))
        {
            SetSelected(0);
        } else if (Input.GetKeyDown("2"))
        {
            SetSelected(1);
        } else if (Input.GetKeyDown("3"))
        {
            SetSelected(2);
        } else if (Input.GetKeyDown("4"))
        {
            SetSelected(3);
        } else if (Input.GetKeyDown("5"))
        {
            SetSelected(4);
        } else if (Input.GetKeyDown("6"))
        {
            SetSelected(5);
        } else if (Input.GetKeyDown("7"))
        {
            SetSelected(6);
        } else if (Input.GetKeyDown("8"))
        {
            SetSelected(7);
        } else if (Input.GetKeyDown("9"))
        {
            SetSelected(8);
        }

        float scrollDeltaY = -Input.mouseScrollDelta.y;
        if (scrollDeltaY != 0)
        {
            if (scrollDeltaY > 0)
            {
                IncreaseSelected();
            } else
            {
                DecreaseSelected();
            }
        }
    }
}
