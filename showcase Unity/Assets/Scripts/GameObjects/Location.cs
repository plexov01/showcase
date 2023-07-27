using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NameLocation", menuName = "Location")]
public class Location : ScriptableObject
{
    public string Name;
    
    public string Description;
    
    public Sprite Picture;
    
    public int SceneId;

    public void CreateLocation(string Name, string Description, Sprite Picture, int SceneId)
    {
        this.Name = Name;
        this.Description = Description;
        this.Picture = Picture;
        this.SceneId = SceneId;
        
    }

}
