using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeciesDatabase : MonoBehaviour
{
    public List<Species> species = new List<Species>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Species GetSpecies(int id)
    {
        return species.Find(species => species.id == id);
    }

    public Species GetSpecies(string speciesName)
    {
        return species.Find(species => species.name == speciesName);
    }

    private void BuildDatabase()
    {

        string plantSpritePath = "sprites/plants/";

        AddSpecies("Potato", "Round and brown", new List<GrowthStage>() {
            new GrowthStage(Resources.Load<Sprite>(plantSpritePath + "plant-1-stage-1")),
            new GrowthStage(Resources.Load<Sprite>(plantSpritePath + "plant-1-stage-2")),
            new GrowthStage(Resources.Load<Sprite>(plantSpritePath + "plant-1-stage-3"))
        });
    }

    private void AddSpecies(string name, string description, List<GrowthStage> growthStages)
    {
        species.Add(new Species(species.Count, name, description, growthStages));
    }
}
