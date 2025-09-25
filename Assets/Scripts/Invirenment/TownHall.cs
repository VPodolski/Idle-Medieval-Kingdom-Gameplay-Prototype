using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour, IInvirenment
{
    private Sprite sprite;

    public string Title { get; set; }
    public int Level { get; set; }
    public CostResources Costs { get; set; }
    public IEnumerable<IInvirenmentProperty> Properties { get; set; }

    void Start()
    {
        Title = "Ратуша";
        Level = 1;

        Costs = new CostResources
        {
            Food = 1,
            Metal = 1,
            Peasants = 1,
            Wood = 1
        };

        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseDown()
    {
        if (!UIManager.Instance.IsInvirenmentPanelActive())
        {
            UIManager.Instance.ShowInvirenmentPanel("Ратуша", sprite);
        }
        else
        {
            UIManager.Instance.HideInvirenmentPanel();
        }
    }
}
