using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : BaseMVCController<TerrainView,TerrainModel> {

    /// <summary>
    /// 创建地形方块
    /// </summary>
    public void createTerrainBlock()
    {
        mBaseView.showTerrainBlock(new Vector3(0,0,0),new Quaternion());
    }

}
