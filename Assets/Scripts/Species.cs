using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Species
{
    public int id;
    public string name;
    public string description;

    public int harvestMin;
    public int harvestMax;

    public List<GrowthStage> growthStages;

    public Species(int id, string name, string description, List<GrowthStage> growthStages, int harvestMin = 1, int harvestMax = 3)
    {
        this.name = name;
        this.description = description;
        this.growthStages = growthStages;
        this.harvestMin = harvestMin;
        this.harvestMax = harvestMax;
    }
}