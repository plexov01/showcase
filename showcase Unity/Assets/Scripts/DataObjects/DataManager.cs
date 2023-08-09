using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager<T> : ScriptableObject,IDataManager<T>
{
    [SerializeField] protected List<string> _idAllObjects;
    [SerializeField] protected T _containerWithDataObject;
    private int _index;

    public T GetDataСontainer()
    {
        return _containerWithDataObject;
    }

    public void SetDataСontainer(T container)
    {
        _containerWithDataObject = container;
    }

    public string GetObjectStringIdByIndex(int index)
    {
        return _idAllObjects[index];
    }
    
    public string GetCurrentObjectString()
    {
        return _idAllObjects[_index];
    }
    public int GetCurrentIndex()
    {
        return _index;
    }
    
    public void IncreaseIndex()
    {
        if (_index<_idAllObjects.Count-1)
        {
            _index++;
        }
    }
    
    public void DecreaseIndex()
    {
        if (_index>0)
        {
            _index--;
        }
    }

}
