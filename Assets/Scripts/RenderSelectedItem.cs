using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSelectedItem : MonoBehaviour
{
    public SpriteRenderer sr;
    public Inventory inventory;
    public ItemDatabase itemDatabase;


    // Update is called once per frame
    void Update()
    {

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
