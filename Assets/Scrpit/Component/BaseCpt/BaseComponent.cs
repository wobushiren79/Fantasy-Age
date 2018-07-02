using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseComponent<V,C> : MonoBehaviour
    where V:Component
    where C:Component
{
    protected V mBaseView;
    protected C mBaseController;

    private void Awake()
    {
        mBaseView= gameObject.AddComponent<V>();
        mBaseController= gameObject.AddComponent<C>();
    }

}
