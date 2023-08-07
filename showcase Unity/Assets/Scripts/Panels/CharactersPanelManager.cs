using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharactersPanelManager : PanelManager,IPanelManager
{
    [SerializeField] private GameObject _gameObjectLevelCharacter;

    [SerializeField] private EntityCreatorManager _entityCreatorManager;

    private TMP_Text _textNameCharacter;
    private TMP_Text _textLevelCharacter;

    private Character _containerWithSelectedCharacter;
    [SerializeField] private CharactersDataManager _charactersDataManager;
    private void Start()
    {
        _textNameCharacter = _gameObjectName.GetComponent<TMP_Text>();
        _textLevelCharacter = _gameObjectLevelCharacter.GetComponent<TMP_Text>();
        
        showObject(_charactersDataManager.GetCurrentObjectString());
        
    }

    public void showObject(string id)
    {
        // load character from Resources
        _containerWithSelectedCharacter = Resources.Load<Character>("GameObjects/Characters/" + id);

        // assign character data to elements
        _textNameCharacter.text = _containerWithSelectedCharacter.Name;
        _textLevelCharacter.text = "level: " + _containerWithSelectedCharacter.Level;
        _imageObject2D.sprite = _containerWithSelectedCharacter.ObjectSprite;

        _entityCreatorManager.CreateObject(_containerWithSelectedCharacter.Id, _containerWithSelectedCharacter.Prefab,
            Vector3.zero, Quaternion.identity);
        
    }

    public void ButtonChoose()
    {
        Debug.Log("Was chosen - " + _containerWithSelectedCharacter.Name);
        _charactersDataManager.SetDataСontainer(_containerWithSelectedCharacter);

    }
    public void MoveNext()
    {
        _charactersDataManager.IncreaseIndex();

        showObject(_charactersDataManager.GetCurrentObjectString());
    }
    public void MovePrevious()
    {
        _charactersDataManager.DecreaseIndex();
        showObject(_charactersDataManager.GetCurrentObjectString());
    }
    
}
