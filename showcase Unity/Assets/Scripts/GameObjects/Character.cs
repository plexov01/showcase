using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Name_Character", menuName = "Character")]
public class Character : SelectableObject
{
    [SerializeField] private int _level;
    
    [SerializeField] private GameObject _prefab;
    public int Level
    {
        get => _level;
        set => _level = value; 
    }
    
    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value; 
    }
}
