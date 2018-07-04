

using UnityEngine;

public class TerrainBlockBean : BaseBean {

    //地形方块名称
    public string terrainBlockName;

    //地形方块坐标
    public float terrainBlockX;
    public float terrainBlockY;
    public float terrainBlockZ;


    /// <summary>
    /// 获取地形方块的坐标位置
    /// </summary>
    /// <returns></returns>
    public Vector3 getTerrainBlockPosition()
    {
        return new Vector3(terrainBlockX, terrainBlockY, terrainBlockZ);
    }
}
