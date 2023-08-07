using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "NameLocation", menuName = "Location")]
public class Location : SelectableObject
{
    [SerializeField] private string _description;
    
    [SerializeField] private int _sceneId;
    public string Description
    {
        get => _description;
        set => _description = value; 
    }
    public int SceneId
    {
        get => _sceneId;
        set => _sceneId = value; 
    }
}
