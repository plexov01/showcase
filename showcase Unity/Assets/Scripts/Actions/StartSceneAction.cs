using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneAction : MonoBehaviour
{
    //Action shoukd be active after start scene
    public static Action SceneStarted;

    private void Start()
    {
        SceneStarted?.Invoke();
    }
}
