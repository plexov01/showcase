using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro.EditorUtilities;
using UnityEngine;
[CreateAssetMenu(fileName = "New EntityCreatorManager", menuName = "EntityCreator Manager")]
public class EntityCreatorManager : ScriptableObject
{
    private List<GameObject> _pool3dObjects = new List<GameObject>();
    
    public GameObject CreateObject(string Id, GameObject Prefab,Vector3 position, Quaternion rotation)
    {
        if (_pool3dObjects.Count>0)
        {
            for (int i = 0; i < _pool3dObjects.Count; i++)
            {
                _pool3dObjects[i].SetActive(false);
            }
        }
        //checking object in pool
        var instance = _pool3dObjects.FirstOrDefault(obj => obj.name == Id);
        
        if (instance)
        {
            instance.SetActive(true);
            return null;
        }
            
        //if not in the pool - instantiate and add to the pool
        GameObject newInstace = Instantiate(Prefab, position, rotation);
                
        newInstace.transform.localPosition = Vector3.zero;
        newInstace.name = Id;
                
        _pool3dObjects.Add(newInstace);
            
        return null;
    }
}
