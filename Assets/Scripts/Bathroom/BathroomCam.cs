using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomCam : MonoBehaviour
{
    public GameObject player;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(
            player.transform.position.x,
            player.transform.position.y + 10,
            player.transform.position.z - 10);

        cam.transform.position = newPos;
    }
}
