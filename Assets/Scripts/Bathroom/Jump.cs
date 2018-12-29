using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float height;
    public AudioClip aClip;
    public AudioSource aSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            aSource.PlayOneShot(aClip);
            other.GetComponent<Rigidbody>().AddForce(0f, height * 100, 0f);
        }
    }
}
