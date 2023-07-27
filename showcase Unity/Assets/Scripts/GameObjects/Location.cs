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

    public void CreateLocation(string name, string description, Sprite picture, int sceneId)
    {
        this.Name = name;
        this.Description = description;
        this.Picture = picture;
        this.SceneId = sceneId;
        
    }

}
