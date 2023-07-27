using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New ObjectPool", menuName = "Object Pool")]
public class ObjectPool : ScriptableObject
{
   /// List of the objects to be pooled
   public List<GameObject> PrefabsForPool;
   
   /// List of the pooled objects
   [SerializeField] private List<GameObject> _pooledObjects = new List<GameObject>();
   
   private GameObject _poolForObjects;
   
   public GameEvent PoolForObjectsGot;
   
   public void GetPoolForObjects(GameObject poolForObjects)
   {
      _poolForObjects = poolForObjects;
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
         // Get the GameObject in Canvas
         PoolForObjectsGot.Raise();

         // Create a new instance
         GameObject newInstace = Instantiate(prefab, Vector3.zero, Quaternion.identity,_poolForObjects.transform);
         
         // Make sure you set it's name (so you remove the Clone that Unity ads)
         newInstace.name = objectName;

         // Set it's position to zero
         newInstace.transform.localPosition = Vector3.zero;
         
         _pooledObjects.Add(newInstace);
         
         return newInstace;
      }
      
      Debug.LogWarning("Object pool doesn't have a prefab for the object with name " + objectName);
      return null;
   }
   
}
