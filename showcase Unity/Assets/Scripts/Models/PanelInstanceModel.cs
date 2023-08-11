using System;
using UnityEngine;
[Serializable]
public class PanelInstanceModel
{
    // The Id of the panel
    private string _panelId;
    
    // The instance of the panel
    private GameObject _panelInstance;
    
    public string PanelId
    {
        get => _panelId;
        set => _panelId = value; 
    }
    public GameObject PanelInstance
    {
        get => _panelInstance;
        set => _panelInstance = value; 
    }
}
