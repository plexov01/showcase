using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NameLocation", menuName = "Location")]
public class Location : ScriptableObject
{
    [SerializeField] private string _name;
    
    [SerializeField] private string _description;
    
    [SerializeField] private Sprite _picture;
    
    [SerializeField] private int _sceneID;
    
    public string Name
    {
        get { return _name; }
    }
    public string Description
    {
        get { return _description; }
    }
    public Sprite Picture
    {
        get { return _picture; }
    }

    public int SceneId
    {
        get {
            return _sceneID;
        }
    }
}
