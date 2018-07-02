using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CptTerrainBlock : MonoBehaviour
{

    //地形方块控制器
    private TerrainBlockController mBlockController;
    //地形方块显示
    private TerrainBlockView mBlockView;

    /// <summary>
    /// 初始化
    /// </summary>
    private void Awake()
    {
        //初始化相关参数
        mBlockView = gameObject.AddComponent<TerrainBlockView>();
        mBlockController = gameObject.AddComponent<TerrainBlockController>();
    }

    /// <summary>
    /// 开始
    /// </summary>
    private void Start()
    {
    }
}
