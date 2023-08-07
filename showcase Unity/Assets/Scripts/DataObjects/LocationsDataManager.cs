using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "LocationsDataManager", menuName = "LocationsDataManager")]
public class LocationsDataManager : DataManager,IDataManager<Location>
{
    [SerializeField] private Location _containerWithLocation;
    
    public Location GetDataСontainer()
    {
        return _containerWithLocation;
    }

    public void SetDataСontainer(Location container)
    {
        _containerWithLocation = container;
    }
}
