using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    static string[] spriteLoc = {
        "",
        "seed/seed",
        "seed/seed2"
    };

    static public Sprite getSpriteByItemId(int itemId)
    {
        Debug.Log("sprites/" + spriteLoc[itemId]);
        return Resources.Load<Sprite>("sprites/" + spriteLoc[itemId]);
    }
}
