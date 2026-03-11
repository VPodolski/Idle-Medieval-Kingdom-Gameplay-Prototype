using System.Collections.Generic;
using UnityEngine;

public interface ITerrainItem
{
    string Title { get; set; }
    TerrainTypes Type { get; set; }
    Transform location { get; set; }
    IEnumerable<IInvirenment> AvailableInvirenments { get; set; }
}
