using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    private void BuildDatabase()
    {
        AddItem("Carrot Seed", "A seed for growing carrots");
        AddItem("Pokeball", "Gotta catch 'em all!");
    }

    private void AddItem(string name, string description)
    {
        items.Add(new Item(items.Count, name, description));
    }
}
