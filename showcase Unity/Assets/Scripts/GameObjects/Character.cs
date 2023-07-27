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
    
    public void CreateCharacter(string Id, string Name,int Level, Sprite Avatar, GameObject Prefab)
    {
        this.Id = Id;
        this.Name = Name;
        this.Level = Level;
        this.Avatar = Avatar;
        this.Prefab = Prefab;
        
    }
}
