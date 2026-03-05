using System.Collections.Generic;
using UnityEngine;

public class TownHall : MonoBehaviour, IInvirenment
{
    private Sprite sprite;
    public string Title { get; set; }
    public int Level { get; set; }
    public CostResources Costs { get; set; }
    public IEnumerable<IInvirenmentProperty> Properties { get; set; }
    public string PathToSprite { get; set; }

    void Start()
    {
        Title = "Ратуша";
        PathToSprite = "Material/Textures/Envirement/Castle/Castle";
        Level = 1;

        Costs = new CostResources
        {
            Food = 1,
            Rock = 1,
            Peasants = 1,
            Wood = 1
        };

        sprite = GetComponent<SpriteRenderer>().sprite;
        Properties = new List<IInvirenmentProperty>();
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

    public void Build()
    {
        
    }
}
