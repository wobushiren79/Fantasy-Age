using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMVCController<V, M> : MonoBehaviour
    where V : BaseMVCView, new()
    where M : BaseMVCModel, new()
{

    // 基础view
    protected V mBaseView;

    // 基础model
    protected M mBaseModel;

    /// <summary>
    /// 构造函数
    /// </summary>
    public BaseMVCController()
    {
      
    }

    private void Awake()
    {
        mBaseModel = new M();
        mBaseView = gameObject.GetComponent<V>();
    }
}
