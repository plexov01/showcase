using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharactersDataPanelManager : MonoBehaviour,IDataManager
{
    [SerializeField] private GameObject _gameObjectNameCharacter;
    [SerializeField] private GameObject _gameObjectLevelCharacter;
    [SerializeField] private Image _image2DAvatar;
    [SerializeField] private List<string> _charactersIdAll;
    
    [SerializeField] private EntityCreatorManager _entityCreatorManager;
    [SerializeField] private Character _currentSelectedCharacter;
    
    private TMP_Text _textNameCharacter;
    private TMP_Text _textLevelCharacter;
    
    private int _index;
    
    private Character _containerWithSelectedCharacter;
    private void Start()
    {
        _textNameCharacter = _gameObjectNameCharacter.GetComponent<TMP_Text>();
        _textLevelCharacter = _gameObjectLevelCharacter.GetComponent<TMP_Text>();
        
        showObject(_charactersIdAll[_index]);
    }

    public void showObject(string id)
    {
        // load character from Resources
        _containerWithSelectedCharacter = Resources.Load<Character>("GameObjects/Characters/" + id);
        
        // assign character data to elements
        _textNameCharacter.text = _containerWithSelectedCharacter.Name;
        _textLevelCharacter.text = "level: " + _containerWithSelectedCharacter.Level.ToString();
        _image2DAvatar.sprite = _containerWithSelectedCharacter.Avatar;

        _entityCreatorManager.CreateObject(_containerWithSelectedCharacter.Id, _containerWithSelectedCharacter.Prefab,
            Vector3.zero, Quaternion.identity);
        
    }

    public void ButtonChoose()
    {
        Debug.Log("Was chosen - " + _containerWithSelectedCharacter.Name);
        _currentSelectedCharacter.CreateCharacter(_containerWithSelectedCharacter.Id,
            _containerWithSelectedCharacter.Name,
            _containerWithSelectedCharacter.Level,
            _containerWithSelectedCharacter.Avatar,
            _containerWithSelectedCharacter.Prefab);
 
    }
    public void MoveNext()
    {
        if (_index<_charactersIdAll.Count-1)
        {
            _index++;
        }

        showObject(_charactersIdAll[_index]);
    }
    public void MovePrevious()
    {
        if (_index>0)
        {
            _index--;
        }
        
        showObject(_charactersIdAll[_index]);
    }
    
}
