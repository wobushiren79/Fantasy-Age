using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainView : BaseMVCView
{
    private string mTerrainBlockResPath = "Prefab/Terrain/PrefabTerrainBlock";

    /// <summary>
    /// 展示一个中心点未0,0,0的地形方块
    /// </summary>
    public void showTerrainBlock(Vector3 position,Quaternion rotation)
    {
        GameObject terrainBlock = InstantiateUtils.CreatePrefab(mTerrainBlockResPath, position, rotation);
        terrainBlock.transform.SetParent(transform);
    }

}
