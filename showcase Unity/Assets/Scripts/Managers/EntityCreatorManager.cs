using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu(fileName = "New EntityCreatorManager", menuName = "EntityCreator Manager")]
public class EntityCreatorManager : ScriptableObject
{
    [SerializeField] private List<GameObject> _pool3dObjects = new List<GameObject>();
    public void CreateObject(string id, GameObject prefab,Vector3 position, Quaternion rotation)
    {
        if (_pool3dObjects.Count>0)
        {
            for (int i = 0; i < _pool3dObjects.Count; i++)
            {
                _pool3dObjects[i].SetActive(false);
            }
        }
        //checking object in pool
        var instance = _pool3dObjects.FirstOrDefault(obj => obj.name == id);
        
        if (instance)
        {
            instance.SetActive(true);
            return;
        }
            
        //if not in the pool - instantiate and add to the pool
        GameObject newInstace = Instantiate(prefab, position, rotation);
                
        newInstace.transform.localPosition = Vector3.zero;
        newInstace.name = id;
                
        _pool3dObjects.Add(newInstace);
        
    }
    //function will do after scene loading
    private void CleanPool3dObjects()
    {
        _pool3dObjects.Clear();
    }

    private void OnEnable()
    {
        StartSceneAction.SceneStarted += CleanPool3dObjects;
    }

    private void OnDisable()
    {
        StartSceneAction.SceneStarted -= CleanPool3dObjects;
    }
    
}
