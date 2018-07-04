using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : BaseMVCController<TerrainView,TerrainModel> {

    /// <summary>
    /// 创建地形方块（基础）
    /// </summary>
    public void createTerrainBlock()
    {
        TerrainBean terrainData=   mBaseModel.getCreateRandomTerrainData(100,100,new Vector3(0,0,0));
        mBaseView.showTerrain(terrainData);
    }

}
