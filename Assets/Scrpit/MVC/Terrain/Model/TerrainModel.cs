using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainModel : BaseMVCModel
{
    //地形数据
    private TerrainBean mTerrainBean;
    private int mUnitTerrain = 1;

    /// <summary>
    /// 获取创建随机地形数据
    /// </summary>
    /// <param name="terrainWide">地形宽</param>
    /// <param name="terrainLong">地形高</param>
    /// <param name="createPosition">地形创建起始位置</param>
    /// <returns></returns>
    public TerrainBean getCreateRandomTerrainData(int terrainWide, int terrainLong, Vector3 createPosition)
    {
        TerrainBean terrainData = new TerrainBean();
        List<TerrainBlockBean> listTerrainBlockData = new List<TerrainBlockBean>();
        float terrainHalfWide = terrainWide / 2f;
        float terrainHalfHigh = terrainLong / 2f;
        float halfUnitTerrain = mUnitTerrain / 2f;
        for (int i = 0; i < terrainWide; i++)
        {
            for (int f = 0; f < terrainLong; f++)
            {
                TerrainBlockBean terrainBlockBean = new TerrainBlockBean();

                float terrainBlockX = i - terrainHalfWide + createPosition.x+ halfUnitTerrain;
                float terrainBlockY = RandomUtils.getFloatRandom(0,1) + createPosition.y + halfUnitTerrain;
                float terrainBlockZ = f - terrainHalfHigh + createPosition.z + halfUnitTerrain;
                string terrainBlockName = "X_" + terrainBlockX + " Y_" + terrainBlockY + " Z_" + terrainBlockZ;

                terrainBlockBean.terrainBlockName = terrainBlockName;
                terrainBlockBean.terrainBlockX = terrainBlockX;
                terrainBlockBean.terrainBlockY = terrainBlockY;
                terrainBlockBean.terrainBlockZ = terrainBlockZ;

                listTerrainBlockData.Add(terrainBlockBean);
            }
        };
        terrainData.listTerrainBlockData = listTerrainBlockData;
        this.mTerrainBean = terrainData;
        return terrainData;
    }



}
