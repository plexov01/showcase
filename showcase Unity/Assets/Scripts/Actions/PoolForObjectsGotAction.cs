using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PoolForObjectsGotAction : MonoBehaviour
{
    //Action should be active after initialization
    public static Action<GameObject> PoolForObjectsGot;

    private ObjectPool _objectPool;
    
    IEnumerator WaitForSign()
    {
        yield return new WaitWhile(()=>!_objectPool.GetStateActionSign());
        PoolForObjectsGot?.Invoke(gameObject);
    }
    private void Start()
    {
        _objectPool = Resources.Load<ObjectPool>("ScriptableObjects/ObjectPool");
        //waiting the sign of action
        StartCoroutine(WaitForSign());

    }
}
