using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New ObjectPool", menuName = "Object Pool")]
public class ObjectPool : ScriptableObject
{
   // List of the objects to be pooled
   [SerializeField] private List<GameObject> PrefabsForPool;
   
   // List of the pooled objects
   private List<GameObject> _pooledObjects = new List<GameObject>();
   
   private GameObject _poolForObjects;
   private bool _actionsSigned = false;
   
   public void GetPoolForObjects(GameObject poolForObjects)
   {
      _poolForObjects = poolForObjects;
      if (_poolForObjects==null)
      {
         Debug.Log($"Trying to get poolForObjects = {_poolForObjects}, but something goes wrong");
      }
   }
   
   public GameObject GetObjectFromPool(string objectName)
   {
      // Try to get a pooled instance
      var instance = _pooledObjects.FirstOrDefault(obj => obj.name == objectName);
      
      // If we have a pooled instance already
      if (instance != null)
      {
         // Enable it
         instance.SetActive(true);
         return instance;
      }
      
      // If we don't have a pooled instance
      var prefab = PrefabsForPool.FirstOrDefault(obj => obj.name == objectName);
      if (prefab != null)
      {
         // Create a new instance
         GameObject newInstance = Instantiate(prefab, Vector3.zero, Quaternion.identity,_poolForObjects.transform);
         
         // Make sure you set it's name (so you remove the Clone that Unity ads)
         newInstance.name = objectName;

         // Set it's position to zero
         newInstance.transform.localPosition = Vector3.zero;
         
         _pooledObjects.Add(newInstance);
         
         return newInstance;
      }
      
      Debug.LogWarning("Object pool doesn't have a prefab for the object with name " + objectName);
      return null;
   }
   //return the state of action sign
   public bool GetStateActionSign()
   {
      return _actionsSigned;
   }
   //function will do after scene loading
   private void CleanPooledObjects()
   {
      _pooledObjects.Clear();
   }

   private void OnEnable()
   {
      PoolForObjectsGotAction.PoolForObjectsGot += GetPoolForObjects;
      StartSceneAction.SceneStarted += CleanPooledObjects;
      _actionsSigned = true;

   }

   private void OnDisable()
   {
      StartSceneAction.SceneStarted -= CleanPooledObjects;
      PoolForObjectsGotAction.PoolForObjectsGot -= GetPoolForObjects;
      _actionsSigned = false;
   }
   
}
