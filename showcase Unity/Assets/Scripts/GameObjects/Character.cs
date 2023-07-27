using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Name_Character", menuName = "Character")]
public class Character : ScriptableObject
{
    [SerializeField] private string _id;
    
    [SerializeField] private string _name;
    
    [SerializeField] private int _level;
    
    [SerializeField] private Sprite _avatar;
    
    [SerializeField] private GameObject _prefab;
    
    public string Id
    {
        get { return _id; }
    }
    public string Name
    {
        get { return _name; }
    }
    public int Level
    {
        get { return _level; }
    }
    public Sprite Avatar
    {
        get { return _avatar; }
    }
    public GameObject Prefab
    {
        get { return _prefab; }
    }
}
