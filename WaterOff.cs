using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOff : MonoBehaviour
{
    public PuzzleCheck inc;
    public ParticleSystem water;
    public ParticleSystem water2;

    void Start()
    {
        water.Play();
        water2.Play();

        inc.WaterCounter = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("It's in");
        inc.WaterCounter++;
        water.Stop();
        water2.Stop();
    }
}
