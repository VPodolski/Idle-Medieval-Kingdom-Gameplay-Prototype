using System;
using System.Collections.Generic;
using UnityEngine;

public class Sawmill : MonoBehaviour, IInvirenment
{
    public string Title { get; set; }
    public string PathToSprite { get; set; }
    public int Level { get; set; }

    public decimal WoodProductionIncrease { get; set; }

    public CostResources Costs { get; set; }

    public IEnumerable<IInvirenmentProperty> Properties { get; set; }
    public ITerrainItem ParentTerrainItem { get; set; }

    public Sawmill()
    {
        PathToSprite = "Material/Textures/Envirement/Terrain/Sawmill";
    }

    public void Start()
    {
        Properties = GetAvailableInvirenmentProperty();
    }

    public void Build()
    {
        if (ResourscesManager.Instance.TrySpendResources(Costs) && ParentTerrainItem != null)
        {
            Transform parentLocation = ParentTerrainItem.location;
            GameObject prefab = Resources.Load<GameObject>("Prefabs/Invirenment/Sawmill");
            prefab.GetComponent<Sawmill>().Level = 1;
            prefab.GetComponent<Sawmill>().Costs = new CostResources(1, 3, 2, 3);
            prefab.GetComponent<Sawmill>().WoodProductionIncrease = 2;

            Instantiate(prefab, parentLocation.position, parentLocation.rotation, parentLocation.parent);
            Destroy(ParentTerrainItem.location.gameObject);

            ResourscesManager.Instance.WoodProduction += WoodProductionIncrease;

            UIManager.Instance.HideInvirenmentPanel();
        }
        else 
        {
            Debug.Log("Not enought resources!");
        }
    }

    private IEnumerable<IInvirenmentProperty> GetAvailableInvirenmentProperty()
    {
        return new List<IInvirenmentProperty>();
    }
}
