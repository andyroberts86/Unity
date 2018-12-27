using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    public GameObject lift;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = lift.GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.enabled = true;
        }
    }
}
