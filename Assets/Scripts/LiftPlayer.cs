﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftPlayer : MonoBehaviour
{
    public Rigidbody player;
    private bool isInContact = false;
    private Transform lift;
    //private AudioClip clip;
    //public AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()
    {
        lift = GetComponent<Transform>();

        //clip = Resources.Load<AudioClip>("liftEnter");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isInContact)
        {
            player.transform.position = new Vector3(
                player.transform.position.x,
                lift.position.y + 0.6f,
                player.transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("Enter");
            isInContact = true;
            player.useGravity = false;

            //audiosrc.PlayOneShot(clip);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("Exit");
            isInContact = false;
            player.useGravity = true;

            //audiosrc.PlayOneShot(clip);
        }
    }

}
