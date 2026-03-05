using System.Collections.Generic;
using UnityEngine;

public class Sawmill : MonoBehaviour, IInvirenment
{
    public string Title { get; set; }
    public string PathToSprite { get; set; }
    public int Level { get; set; }

    public decimal WoodProductionIncrease;

    public CostResources Costs { get; set; }

    public IEnumerable<IInvirenmentProperty> Properties { get; set; }

    public Forest ParentForest;

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
        ResourscesManager.Instance.WoodProduction += WoodProductionIncrease;
    }

    private IEnumerable<IInvirenmentProperty> GetAvailableInvirenmentProperty()
    {
        return new List<IInvirenmentProperty>();
    }
}
