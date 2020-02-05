using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantpot : Interactable
{
    public Inventory playerInventory;

    public GameObject plantInstance;
    public GameObject plantPrefab;

    public Plant plant;

    override public void Interact()
    {
        if (plantInstance)
        {
            Debug.Log("Plant already here bro");

            plant.growthStage++;
            plant.UpdateGrowth();

            return;
        }

        plantInstance = Instantiate(plantPrefab, transform.position, Quaternion.identity);
        plant = plantInstance.GetComponent<Plant>();

        plant.Initialize(0);

        plant.transform.SetParent(transform);
    }
}
