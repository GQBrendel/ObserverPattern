using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : Observer 
{
    [SerializeField] private UITopPanel _uITopPanel;

    private bool _achievInlocked;

    public override void OnNotify()
    {
        if (_achievInlocked)
        {
            return;
        }
        _achievInlocked = true;
        _uITopPanel.PlayAnimation();
    }
}