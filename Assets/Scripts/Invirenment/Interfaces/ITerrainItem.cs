using System.Collections.Generic;
using UnityEngine;

public interface ITerrainItem
{
    string Title { get; set; }
    TerrainTypes Type { get; set; }
    IEnumerable<IInvirenment> AvailableInvirenments { get; set; }
}
