using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour, ITerrainItem
{

    public string Title { get; set; }
    public TerrainTypes Type { get; set; }
    public IEnumerable<IInvirenment> AvailableInvirenments { get; set; }
    Sprite sprite { get; set; }
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        Title = "Лес";
        Type = TerrainTypes.Forest;
        AvailableInvirenments = GetAvailableInvirenment();
    }

    private void OnMouseDown()
    {
        if (!UIManager.Instance.IsInvirenmentPanelActive())
        {
            UIManager.Instance.ShowInvirenmentPanel(this, sprite);
        }
        else
        {
            UIManager.Instance.HideInvirenmentPanel();
        }
    }

    private IEnumerable<IInvirenment> GetAvailableInvirenment()
    {
        var sawmill = gameObject.AddComponent<Sawmill>();

        sawmill.Title = "Лесопилка";
        sawmill.Level = 1;
        sawmill.ParentForest = this;
        sawmill.Costs = new CostResources
        {
            Food = 1,
            Peasants = 1,
            Rock = 1,
            Wood = 0
        };
        sawmill.WoodProductionIncrease = 0.1m;

        var result = new List<IInvirenment>
        {
            sawmill
        };

        return result;
    }
}
