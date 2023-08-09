using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharactersPanelManager : PanelManager<Character>
{
    [SerializeField] private GameObject _gameObjectLevelCharacter;

    [SerializeField] private EntityCreatorManager _entityCreatorManager;

    [SerializeField] private CharactersDataManager _charactersDataManager;
    
    private TMP_Text _textNameCharacter;
    private TMP_Text _textLevelCharacter;

    private void Start()
    {
        _textNameCharacter = _gameObjectName.GetComponent<TMP_Text>();
        _textLevelCharacter = _gameObjectLevelCharacter.GetComponent<TMP_Text>();
        
        showObject(_charactersDataManager.GetCurrentObjectString());
        
    }

    public override void showObject(string id)
    {
        // load character from Resources
        _containerWithDataObject = Resources.Load<Character>("GameObjects/Characters/" + id);

        // assign character data to elements
        _textNameCharacter.text = _containerWithDataObject.Name;
        _textLevelCharacter.text = "level: " + _containerWithDataObject.Level;
        _imageObject2D.sprite = _containerWithDataObject.ObjectSprite;

        _entityCreatorManager.CreateObject(_containerWithDataObject.Id, _containerWithDataObject.Prefab,
            Vector3.zero, Quaternion.identity);
        
    }

    public override void ButtonChoose()
    {
        _charactersDataManager.SetDataСontainer(_containerWithDataObject);
        Debug.Log("Was choosen character: "+_containerWithDataObject.Name);

    }
    public override void MoveNext()
    {
        _charactersDataManager.IncreaseIndex();
        showObject(_charactersDataManager.GetCurrentObjectString());
    }
    public override void MovePrevious()
    {
        _charactersDataManager.DecreaseIndex();
        showObject(_charactersDataManager.GetCurrentObjectString());
    }

}
