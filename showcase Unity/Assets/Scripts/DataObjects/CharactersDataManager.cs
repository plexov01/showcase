using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CharactersDataManager", menuName = "CharactersDataManager")]
public class CharactersDataManager : DataManager,IDataManager<Character>
{
    [SerializeField] private Character _containerWithCharacter;

    public Character GetDataСontainer()
    {
        return _containerWithCharacter;
    }

    public void SetDataСontainer(Character container)
    {
        _containerWithCharacter = container;
    }
}
