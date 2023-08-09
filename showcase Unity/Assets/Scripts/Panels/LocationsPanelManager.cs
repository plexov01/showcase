using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationsPanelManager : PanelManager<Location>
{
    [SerializeField] private GameObject _gameObjectLevelLocation;
    [SerializeField] private GameObject _gameObjectIdLocation;

    [SerializeField] private LoadSceneManager _loadSceneManager;
    
    [SerializeField] private LocationsDataManager _locationsDataManager;
    
    private TMP_Text _textNameLocation;
    private TMP_Text _textDescriptionOfLocation;
    private TMP_Text _textIdLocation;

    void Start()
    {
        _textNameLocation = _gameObjectName.GetComponent<TMP_Text>();
        _textDescriptionOfLocation = _gameObjectLevelLocation.GetComponent<TMP_Text>();
        _textIdLocation = _gameObjectIdLocation.GetComponent<TMP_Text>();
        
        showObject(_locationsDataManager.GetCurrentObjectString());
        
    }

    public override void showObject(string id)
    {
        // load location from Resources
        _containerWithDataObject = Resources.Load<Location>("GameObjects/Scenes/" + id);
        
        // assign location data to elements
        _textNameLocation.text = _containerWithDataObject.Name;
        _textDescriptionOfLocation.text = _containerWithDataObject.Description;
        _imageObject2D.sprite = _containerWithDataObject.ObjectSprite;
        _textIdLocation.text = "Id Scene: " + _containerWithDataObject.SceneId;
        
    }

    public override void ButtonChoose()
    {
        _loadSceneManager.LoadSceneByName(_containerWithDataObject.Name);
        _locationsDataManager.SetDataСontainer(_containerWithDataObject);
    }

    public override void MoveNext()
    {
        _locationsDataManager.IncreaseIndex();
        showObject(_locationsDataManager.GetCurrentObjectString());
    }

    public override void MovePrevious()
    {
        _locationsDataManager.DecreaseIndex();
        showObject(_locationsDataManager.GetCurrentObjectString());
    }
}
