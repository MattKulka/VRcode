using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tempCheckForDialogue : MonoBehaviour
{
    public PuzzleCheck count;
    public Flowchart myFlowchart;

    public bool tempCheck()
    {
        if (count.counter == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}