using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(fileName = "New LoadSceneManager", menuName = "LoadScene Manager ")]
public class LoadSceneManager : ScriptableObject
{
    public void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

}
