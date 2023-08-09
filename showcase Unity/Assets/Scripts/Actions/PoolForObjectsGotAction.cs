using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoolForObjectsGotAction : MonoBehaviour
{
    //Action should be active after initialization
    public static Action<GameObject> PoolForObjectsGot;
    private void Start()
    {
        PoolForObjectsGot?.Invoke(gameObject);
    }
}
