using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    public static int INVENTORY_SIZE = 10;

    private Item[] items = new Item[INVENTORY_SIZE];
    private int[] quantity = new int[INVENTORY_SIZE];
    public int selected = 0;
    
    public int AddItem(Item item)
    {
        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            if (items[i] == item)
            {
                quantity[i]++;
                return i;
            }
        }

        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                quantity[i] = 1;
                return i;
            }
        }

        return -1;
    }

    public Item GetSelectedItem()
    {
        return items[selected];
    }

    public void IncreaseSelected()
    {
        selected = (selected + 1) % INVENTORY_SIZE;
    }

    public void DecreaseSelected()
    {
        if (selected == 0)
        {
            selected = INVENTORY_SIZE;
        } else
        {
            selected--;
        }
    }

    public void SetSelected(int slot)
    {
        selected = Mathf.Abs(slot) % INVENTORY_SIZE;
    }

    private void Update()
    {
        if (Input.GetKeyDown("0"))
        {
            selected = 9;
        } else if (Input.GetKeyDown("1"))
        {
            selected = 0;
        } else if (Input.GetKeyDown("2"))
        {
            selected = 1;
        } else if (Input.GetKeyDown("3"))
        {
            selected = 2;
        } else if (Input.GetKeyDown("4"))
        {
            selected = 3;
        } else if (Input.GetKeyDown("5"))
        {
            selected = 4;
        } else if (Input.GetKeyDown("6"))
        {
            selected = 5;
        } else if (Input.GetKeyDown("7"))
        {
            selected = 6;
        } else if (Input.GetKeyDown("8"))
        {
            selected = 7;
        } else if (Input.GetKeyDown("9"))
        {
            selected = 8;
        }
    }
}
