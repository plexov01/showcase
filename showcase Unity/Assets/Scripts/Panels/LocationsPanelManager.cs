using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationsPanelManager : PanelManager, IPanelManager 
{
    [SerializeField] private GameObject _gameObjectLevelLocation;
    [SerializeField] private GameObject _gameObjectIdLocation;

    [SerializeField] private LoadSceneManager _loadSceneManager;

    private TMP_Text _textNameLocation;
    private TMP_Text _textDescriptionOfLocation;
    private TMP_Text _textIdLocation;

    [SerializeField]private Location _containerWithSelectedLocation;
    [SerializeField] private LocationsDataManager _locationsDataManager;

    void Start()
    {
        _textNameLocation = _gameObjectName.GetComponent<TMP_Text>();
        _textDescriptionOfLocation = _gameObjectLevelLocation.GetComponent<TMP_Text>();
        _textIdLocation = _gameObjectIdLocation.GetComponent<TMP_Text>();
        
        showObject(_locationsDataManager.GetCurrentObjectString());
        
    }

    public void showObject(string id)
    {
        // load location from Resources
        _containerWithSelectedLocation = Resources.Load<Location>("GameObjects/Scenes/" + id);
        
        // assign location data to elements
        _textNameLocation.text = _containerWithSelectedLocation.Name;
        _textDescriptionOfLocation.text = _containerWithSelectedLocation.Description;
        _imageObject2D.sprite = _containerWithSelectedLocation.ObjectSprite;
        _textIdLocation.text = "Id Scene: " + _containerWithSelectedLocation.SceneId;
        
    }

    public void ButtonChoose()
    {
        _loadSceneManager.LoadSceneByName(_containerWithSelectedLocation.Name);
        _locationsDataManager.SetDataСontainer(_containerWithSelectedLocation);
    }

    public void MoveNext()
    {
        _locationsDataManager.IncreaseIndex();
        showObject(_locationsDataManager.GetCurrentObjectString());
    }

    public void MovePrevious()
    {
        _locationsDataManager.DecreaseIndex();
        showObject(_locationsDataManager.GetCurrentObjectString());
    }
}
