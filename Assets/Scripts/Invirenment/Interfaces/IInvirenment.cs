using System.Collections.Generic;
using UnityEngine;

public interface IInvirenment
{
    string Title { get; set; }
    int Level { get; set; }
    CostResources Costs { get; set; }
    IEnumerable<IInvirenmentProperty> Properties { get; set; }
}
