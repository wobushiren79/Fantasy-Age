using UnityEngine;
using UnityEditor;

public class RandomUtils 
{

    /// <summary>
    /// 获取一个Int类型的随机数
    /// </summary>
    /// <param name="start">起始</param>
    /// <param name="end">结束（不包含）</param>
    /// <returns></returns>
    public static int getIntRandom(int start, int end) {
      return  Random.Range(start, end);
    }

    /// <summary>
    /// 获取一个Float类型的随机数
    /// </summary>
    /// <param name="start">起始</param>
    /// <param name="end">结束（不包含）</param>
    /// <returns></returns>
    public static float getFloatRandom(float start, float end){
        return Random.Range(start, end);
    }
}