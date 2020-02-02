using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSelectedItem : MonoBehaviour
{
    public SpriteRenderer sr;
    private Inventory inventory;

    public ItemDatabase db;

    void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("b"))
        {
            inventory.AddItem(db.GetItem(0));
        }

        if (Input.GetKeyDown("c"))
        {
            inventory.AddItem(db.GetItem(1));
        }


        Item item = inventory.GetSelectedItem();
        if (item != null)
        {
            sr.sprite = item.sprite;
        } else
        {
            sr.sprite = null;
        }
    }
}
