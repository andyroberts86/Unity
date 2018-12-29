using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRoomCam : MonoBehaviour
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
            player.transform.position.y + 15,
            player.transform.position.z - 10);

        cam.transform.position = newPos;
    }
}
