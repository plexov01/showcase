using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New PanelManager", menuName = "Panels Manager")]
public class PanelsManager : ScriptableObject
{
    // for hold all of instances
    [SerializeField] private List<PanelInstanceModel> _panelInstanceModels = new List<PanelInstanceModel>();
    
    [SerializeField] private ObjectPool _objectPool;

    public void ShowPanel(string panelId)
    {
        // Get a panel instance from the ObjectPool
        GameObject panelInstance = _objectPool.GetObjectFromPool(panelId);
        
        // If we have one
        if (panelInstance!=null)
        {
            // If we should hide the previous panel, and we have one
            if ( GetAmountPanelsInList() > 0)
            {
                // Get the last panel
                var lastPanel = GetLastPanel();
                
                // Disable it
                lastPanel?.PanelInstance.SetActive(false);

            }
            //Remove ols panels
            _panelInstanceModels.Clear();
            // Add this new panel to the list
            _panelInstanceModels.Add(new PanelInstanceModel
            {
                PanelId = panelId,
                PanelInstance = panelInstance
            });

        }
        else
        {
            Debug.LogWarning($"Trying to use panelId = {panelId}, but this is not found in the ObjectPool");
        }
    }
    
    /// Returns the last panel in the list
    PanelInstanceModel GetLastPanel()
    {
        return _panelInstanceModels[_panelInstanceModels.Count - 1];
    }
    
    /// Returns how many panels we have in list
    public int GetAmountPanelsInList()
    {
        return _panelInstanceModels.Count;
    }
    
    //function will do after scene loading
    private void CleanPanelInstanceModels()
    {
        _panelInstanceModels.Clear();
    }

    private void OnEnable()
    {
        StartSceneAction.SceneStarted += CleanPanelInstanceModels;
    }

    private void OnDisable()
    {
        StartSceneAction.SceneStarted -= CleanPanelInstanceModels;
    }


}
