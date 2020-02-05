using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthStage
{
    public int id;
    public Sprite sprite;
    public int growthTime;

    public GrowthStage(Sprite sprite, int growthTime = 1)
    {
        this.sprite = sprite;
        this.growthTime = growthTime;
    }
}
