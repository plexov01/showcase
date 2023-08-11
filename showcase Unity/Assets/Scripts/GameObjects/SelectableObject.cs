using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : ScriptableObject
{
    [SerializeField] protected string _id;
    
    [SerializeField] protected string _name;
    
    [SerializeField] protected Sprite _objectSprite;
    
    public string Id
    {
        get => _id;
        set => _id = value; 
    }

    public string Name
    {
        get =>  _name;
        set => _name = value; 
    }
    
    public Sprite ObjectSprite
    {
        get => _objectSprite;
        set => _objectSprite = value; 
    }
}
