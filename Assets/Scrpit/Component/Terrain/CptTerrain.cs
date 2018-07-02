using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CptTerrain : BaseComponent<TerrainView,TerrainController>
{

    private void Start()
    {
        mBaseController.createTerrainBlock();
    }

}
