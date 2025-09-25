using UnityEngine;

public interface IInvirenmentProperty
{
    string Title { get; set; }
    Sprite sprite { get; set; }
    CostResources Costs { get; set; }

    string ActionTitle { get; set; }
    public void Action();
}
