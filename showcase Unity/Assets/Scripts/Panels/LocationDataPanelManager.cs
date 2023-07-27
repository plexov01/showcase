using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationDataPanelManager : MonoBehaviour, IDataManager 
{
    [SerializeField] private GameObject _gameObjectNameLocation;
    [SerializeField] private GameObject _gameObjectLevelLocation;
    [SerializeField] private Image _image2DPicture;
    [SerializeField] private GameObject _gameObjectIdLocation;
    
    [SerializeField] private List<string> _LocationsIdAll;
    
    [SerializeField] private LoadSceneManager _loadSceneManager;
    
    [SerializeField] private Location _currentSelectedLocation;

    private TMP_Text _textNameLocation;
    private TMP_Text _textDescriptionOfLocation;
    private TMP_Text _textIdLocation;
    
    private int _index;
    
    private Location _containerWithSelectedLocation;

    void Start()
    {
        _textNameLocation = _gameObjectNameLocation.GetComponent<TMP_Text>();
        _textDescriptionOfLocation = _gameObjectLevelLocation.GetComponent<TMP_Text>();
        _textIdLocation = _gameObjectIdLocation.GetComponent<TMP_Text>();

        showObject(_LocationsIdAll[_index]);
        
    }

    public void showObject(string Id)
    {
        // load location from Resources
        _containerWithSelectedLocation = Resources.Load<Location>("GameObjects/Scenes/" + Id);
        
        // assign location data to elements
        _textNameLocation.text = _containerWithSelectedLocation.Name;
        _textDescriptionOfLocation.text = _containerWithSelectedLocation.Description;
        _image2DPicture.sprite = _containerWithSelectedLocation.Picture;
        _textIdLocation.text = "Id Scene: " + _containerWithSelectedLocation.SceneId;
        
    }

    public void ButtonChoose()
    {
        _currentSelectedLocation.CreateLocation(_containerWithSelectedLocation.Name,_containerWithSelectedLocation.Description,_containerWithSelectedLocation.Picture,_containerWithSelectedLocation.SceneId);
        _loadSceneManager.LoadSceneByName(_containerWithSelectedLocation.Name);
    }

    public void MoveNext()
    {
        if (_index<_LocationsIdAll.Count-1)
        {
            _index++;
        }

        showObject(_LocationsIdAll[_index]);
    }

    public void MovePrevious()
    {
        if (_index>0)
        {
            _index--;
        }
        
        showObject(_LocationsIdAll[_index]);
    }
}
