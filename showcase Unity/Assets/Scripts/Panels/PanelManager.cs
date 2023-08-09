using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager<T> : MonoBehaviour,IPanelManager
{
    [SerializeField] protected string _ManagerId;
    [SerializeField] protected GameObject _gameObjectName;
    [SerializeField] protected Image _imageObject2D;

    protected T _containerWithDataObject;

    public virtual void showObject(string id){}
    public virtual void MoveNext(){}
    public virtual void MovePrevious(){}
    public virtual void ButtonChoose(){}
    
    protected void OnEnable()
    {
        ButtonEventAdder.ButtonPressed += DoAfterPressedButton;
    }

    protected void OnDisable()
    {
        ButtonEventAdder.ButtonPressed -= DoAfterPressedButton;
    }

    protected void DoAfterPressedButton(ButtonType buttonType, string buttonId)
    {
        if (buttonId!=_ManagerId) return;
        
        switch (buttonType)
        {
            case ButtonType.Next:
                MoveNext();
                break;
            case ButtonType.Previous:
                MovePrevious();
                break;
            case ButtonType.Choose:
                ButtonChoose();
                break;
        }
        
    }
    
}
