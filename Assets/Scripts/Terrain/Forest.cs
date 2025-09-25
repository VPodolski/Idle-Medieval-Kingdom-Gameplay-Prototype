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
            UIManager.Instance.ShowInvirenmentPanel(Title, sprite);
        }
        else
        {
            UIManager.Instance.HideInvirenmentPanel();
        }
    }

    private IEnumerable<IInvirenment> GetAvailableInvirenment()
    {
        var result = new List<IInvirenment>();

        return result;
    }
}
