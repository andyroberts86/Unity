using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCam : MonoBehaviour
{
    public GameObject lift;
    private Transform camTransform;
    private Transform liftTransform;
    private Vector3 startPos;
    private float dy;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = GetComponent<Transform>();
        liftTransform = lift.GetComponent<Transform>();
        startPos = camTransform.position;
        dy = startPos.y - liftTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = new Vector3(startPos.x, liftTransform.position.y + dy, startPos.z);
    }
}
