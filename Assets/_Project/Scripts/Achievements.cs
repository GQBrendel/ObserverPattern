using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : Observer 
{
    public override void OnNotify()
    {
        Debug.Log("Acheivemente Notifyed");
    }
}