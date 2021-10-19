using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour 
{
    public string check;
    public int itemCheck;
    public PuzzleCheck puzzle;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(check))
        {
            Destroy(collision.gameObject);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(check))
        {
            Destroy(other.gameObject);
        }
    }
}
