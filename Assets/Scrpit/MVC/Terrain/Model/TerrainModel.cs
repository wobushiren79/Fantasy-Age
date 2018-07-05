using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainModel : BaseMVCModel
{
    //地形数据
    private TerrainBean mTerrainBean;
    private int mUnitTerrain = 1;

    private float _seedX, _seedZ;
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

        _seedX = Random.value * 100f;
        _seedZ = Random.value * 100f;
        for (int i = 0; i < terrainWide; i++)
        {
            for (int f = 0; f < terrainLong; f++)
            {
                TerrainBlockBean terrainBlockBean = new TerrainBlockBean();

                float terrainBlockX = i - terrainHalfWide + createPosition.x+ halfUnitTerrain;
                float terrainBlockZ = f - terrainHalfHigh + createPosition.z + halfUnitTerrain;
                float terrainBlockY = 0;


                float xSample = (terrainBlockX + _seedX) /15;
                float zSample = (terrainBlockZ + _seedZ) / 15;
                float perlinNoise = Mathf.PerlinNoise(xSample, zSample);
                float terrainBlockHigh = perlinNoise * 10 + createPosition.y;
                string terrainBlockName = "X_" + terrainBlockX + " Y_" + terrainBlockY + " Z_" + terrainBlockZ;

                terrainBlockBean.terrainBlockName = terrainBlockName;
                terrainBlockBean.terrainBlockX = terrainBlockX;
                terrainBlockBean.terrainBlockY = terrainBlockY;
                terrainBlockBean.terrainBlockZ = terrainBlockZ;
                terrainBlockBean.terrainBlockHigh = terrainBlockHigh;

                listTerrainBlockData.Add(terrainBlockBean);
            }
        };
        terrainData.listTerrainBlockData = listTerrainBlockData;
        this.mTerrainBean = terrainData;
        return terrainData;
    }



}
