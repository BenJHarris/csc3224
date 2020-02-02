using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite sprite;

    public Item(int id, string name, string description)
    {
        this.id = id;
        this.title = name;
        this.description = description;
        this.sprite = Resources.Load<Sprite>("Sprites/Items/" + title);
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.sprite = Resources.Load<Sprite>("Sprites/Items/" + item.title);
    }

    public override bool Equals(object obj)
    {
        if ((obj == null) || !(obj is Item))
        {
            return false;
        }
        else
        {
            return (id == ((Item)obj).id);
        }
    }

    public override int GetHashCode()
    {
        return id;
    }
}
