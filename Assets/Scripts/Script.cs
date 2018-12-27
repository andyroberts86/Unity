using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject player;
    private Light spotlight;
    private float dx, dz;

    // Start is called before the first frame update
    void Start()
    {
        spotlight = GetComponent<Light>();
        dx = spotlight.transform.position.x - player.transform.position.x;
        dz = spotlight.transform.position.z - player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = spotlight.transform.position;
        spotlight.transform.position = new Vector3(
            player.transform.position.x + dx, 
            pos.y, 
            player.transform.position.z + dz);
    }
}
