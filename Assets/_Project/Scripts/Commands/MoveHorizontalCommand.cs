using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontalCommand : Command
{
    public override void Execute(Actor actor, float intensity)
    {
        actor.MoveHorizontal(intensity);
    }
}