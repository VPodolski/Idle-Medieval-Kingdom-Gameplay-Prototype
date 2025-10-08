using System.Collections.Generic;

public interface IInvirenment
{
    string Title { get; set; }
    int Level { get; set; }
    CostResources Costs { get; set; }
    IEnumerable<IInvirenmentProperty> Properties { get; set; }

    public void Build();
}
