using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class waterCheckForDialogue : MonoBehaviour
{
    public PuzzleCheck count;
    public Flowchart myFlowchart;

    public bool waterCheck()
    {
        if (count.WaterCounter == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
