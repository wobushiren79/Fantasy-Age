using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainView : BaseMVCView
{
    private string mTerrainBlockResPath = "Prefab/Terrain/PrefabTerrainBlock";

 
 
    /// <summary>
    /// 生成并展示地形
    /// </summary>
    /// <param name="terrainData"></param>
    public void showTerrain(TerrainBean terrainData)
    {
        List<TerrainBlockBean> listTerrainBlockData = terrainData.listTerrainBlockData;
        for (int i = 0; i < listTerrainBlockData.Count; i++) {
            TerrainBlockBean itemData = listTerrainBlockData[i];
            GameObject terrainBlock = InstantiateUtils.CreatePrefab(mTerrainBlockResPath, itemData.getTerrainBlockPosition(), new Quaternion());
            terrainBlock.transform.localScale =new Vector3 (1, itemData.terrainBlockHigh, 1);
            terrainBlock.transform.position = new Vector3(itemData.terrainBlockX, itemData.terrainBlockHigh/2f, itemData.terrainBlockZ);
            terrainBlock.name = itemData.terrainBlockName;
            terrainBlock.transform.SetParent(transform);
        }
    }

}
