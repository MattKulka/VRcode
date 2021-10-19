using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class conferenceCheckForDialogue : MonoBehaviour
{
    public doorLock unlocked;
    int counter = 0;
    public Flowchart myFlowchart;

    public bool confCheck()
    {
        for (int i = 0; i < unlocked.locked.Length; i++)
        {
            if (unlocked.locked[i])
            {
                counter += 1;
            }
        }
        if (counter == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
