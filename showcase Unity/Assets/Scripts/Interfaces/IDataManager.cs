using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDataManager<T>
{
    public T GetDataСontainer();
    public void SetDataСontainer(T container);
    public string GetObjectStringIdByIndex(int index);
}

