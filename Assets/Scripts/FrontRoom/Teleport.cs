using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject newLocation;
    public GameObject player;
    public AudioSource aSrc;
    public AudioClip aClip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            aSrc.PlayOneShot(aClip);
            Rigidbody body = player.GetComponent<Rigidbody>();
            body.Sleep();
            player.transform.position = newLocation.transform.position;
        }
    }
}
