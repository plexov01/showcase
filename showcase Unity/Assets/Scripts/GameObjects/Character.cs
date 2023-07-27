using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Name_Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public string Id;
    
    public string Name;
    
    public int Level;
    
    public Sprite Avatar;
    
    public GameObject Prefab;
    
    public void CreateCharacter(string id, string name, int level, Sprite avatar, GameObject prefab)
    {
        this.Id = id;
        this.Name = name;
        this.Level = level;
        this.Avatar = avatar;
        this.Prefab = prefab;
        
    }
}
