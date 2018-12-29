using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    public GameObject lift;
    public AudioClip clip;
    private Animator anim;
    public AudioSource listener;

    // Use this for initialization
    void Start()
    {
        anim = lift.GetComponent<Animator>();
        anim.enabled = false;
    }

    private bool isFirst = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.enabled = true;

            if (isFirst)
            {
                listener.PlayOneShot(clip);
                isFirst = false;
            }

        }
    }
}
