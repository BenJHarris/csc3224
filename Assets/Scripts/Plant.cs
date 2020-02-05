using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Species species;
    public int growthStage;
    public int age;
    public int timeRemainingOnGrowthStage;

    public Animator animator;
    public SpeciesDatabase speciesDatabase;

    public void Initialize(int SpeciesId)
    {
        species = speciesDatabase.GetSpecies(SpeciesId);
        age = 0;
        growthStage = 0;

        GrowthStage gs = species.growthStages[growthStage];

        animator.SetInteger("stage", growthStage);
        timeRemainingOnGrowthStage = gs.growthTime;
    }

    public void UpdateGrowth()
    {
        List<GrowthStage> growthStages = species.growthStages;
        if (growthStage >= growthStages.Count)
        {
            growthStage = 0;
        }
        animator.SetInteger("stage", growthStage);
    }

}
