using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateUtils
{

    /// <summary>
    /// 创建物体 根据Prefab资源
    /// </summary>
    /// <param name="prefabRes">资源地址</param>
    /// <param name="position">资源位置</param>
    /// <param name="rotation">资源选择角度</param>
    /// <returns></returns>
    public static GameObject CreatePrefab(string prefabRes, Vector3 position, Quaternion rotation)
    {
        GameObject gameObject = GameObject.Instantiate(Resources.Load(prefabRes), position, rotation) as GameObject;
        return gameObject;
    }
}
