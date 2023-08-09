using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventAdder : MonoBehaviour
{
    public ButtonType CurrentButtonType;
    public string ButtonId;
    
    [Header("For hiding object")]
    public bool hideAfterPress;
    public GameObject hiddenObject;
    
    [Header("For showing panel")]
    public string switchablePanelName;
    
    [Header("For loading scene")]
    public string nameScene;
    
    public static Action<ButtonType, string> ButtonPressed;
    
    private Button _button;
    private PanelsManager _panelsManager;
    private LoadSceneManager _loadSceneManager;
    
    void Start()
    {
        _button = GetComponent<Button>();
        _panelsManager = Resources.Load<PanelsManager>("ScriptableObjects/PanelsManager");
        _loadSceneManager = Resources.Load<LoadSceneManager>("ScriptableObjects/LoadSceneManager");
        
        //check have or not the button on the gameObject and add listener
        if (_button)
        {
            _button.onClick.AddListener(ClickAction);
        }
        else
        {
            Debug.LogWarning($"Trying to get button: {gameObject.name}, but this is not found in the gameObject");
        }

    }

    private void ClickAction()
    {
        // hide object if it needs
        if (hideAfterPress) hiddenObject.SetActive(false);
        
        switch (CurrentButtonType)
        {
            case ButtonType.ShowPanel:
                _panelsManager.ShowPanel(switchablePanelName);
                break;
            case ButtonType.LoadScene:
                _loadSceneManager.LoadSceneByName(nameScene);
                break;
            default:
                ButtonPressed?.Invoke(CurrentButtonType,ButtonId);
                break;
        }

        
    }
}


