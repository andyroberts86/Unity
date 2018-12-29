using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject newLocation;
    public GameObject player;
    private GameObject teleport;

    // Start is called before the first frame update
    void Start()
    {
        teleport = GetComponent<GameObject>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            Rigidbody body = player.GetComponent<Rigidbody>();
            body.Sleep();
            player.transform.position = newLocation.transform.position;
        }
    }
}
