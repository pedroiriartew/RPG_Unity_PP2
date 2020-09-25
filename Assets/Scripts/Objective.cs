using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective
{
    public enum ObjectiveType
    {
        position,
        items,
        enemy,
        npc
    }

    private string objectiveName = "Default Objective";
    private ObjectiveType type = default;
    private bool isObjectiveFinished = false;


}
