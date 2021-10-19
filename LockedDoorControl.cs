using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorControl : MonoBehaviour
{

    public GameObject character;
    public float distance = 10f;
    private Animator animator;
    public doorLock locks;
    public int lockCounter = 0;

    private void Start()
    {
        animator = GetComponent<Animator>();

        for (int k = 0; k < locks.locked.Length; k++)
        {
            locks.locked[k] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(character.transform.position, transform.position) <= distance)
        {
            lockCounter = 0;
            for (int i = 0; i < locks.locked.Length; i++)
            {
                if (locks.locked[i])
                {
                    lockCounter += 1;
                }
            }
            Debug.Log("lockCounter: " + lockCounter + " locks.locked.Length: " + locks.locked.Length);
        }

        if(lockCounter == (locks.locked.Length))
        {
            Debug.Log("If fired");
            if (Vector3.Distance(character.transform.position, transform.position) <= distance)
            {
                animator.SetBool("character_nearby", true);
            }
            else
            {
                animator.SetBool("character_nearby", false);
            }
        }
    }
}