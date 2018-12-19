using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneMovement : MonoBehaviour
{
    private float maxX = 0;
    private float minX = 100;
    private float maxZ = 0;
    private float minZ = 100;


    private const float minSpeed = 0.7f;
    readonly float baseSpeed = 0.001f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Log()
    {
        Debug.Log("ANDROB01 - maxX: " + maxX);
        Debug.Log("ANDROB01 - maxZ: " + maxZ);
        Debug.Log("ANDROB01 - minX: " + minX);
        Debug.Log("ANDROB01 - minZ: " + minZ);
    }

    private void LogVector(Vector3 vector)
    {
        float x = Math.Abs(vector.x);
        if(maxX < x)
        {
            maxX = x;
            Log();
        }

        if(minX > x)
        {
            minX = x;
            Log();
        }

        float z = vector.z;
        if (maxZ < z)
        {
            maxZ = z;
            Log();
        }

        if (minZ > z)
        {
            minZ = z;
            Log();
        }

      
    }
    

    void FixedUpdate()
    {
    
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                float time = Input.GetTouch(0).deltaTime;
                float mag = touchDeltaPosition.magnitude;
                float speed = mag/time;
               
                rb.AddForce(GetForce(touchDeltaPosition.x, speed), 0, GetForce(touchDeltaPosition.y, speed));

                LogVector(new Vector3(touchDeltaPosition.x, 0, touchDeltaPosition.y));
            }

            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                //rb.AddForce(0f, 30f, 0f);
            }
        }else
        {
            //ResetSpeed();
        }

        
    }

    private void ResetSpeed()
    {
        float max = 0.8f;
        Vector3 newVelocity = rb.velocity;
        
        if(newVelocity.x < max && newVelocity.x > -max)
        {
            newVelocity.x = 0;
        }

        if (newVelocity.z < max && newVelocity.z > -max)
        {
            newVelocity.z = 0;
        }

        rb.velocity = newVelocity;
    }
    
    float GetForce(float deltaIn, float speed)
    {
        Debug.Log("ANDROB01 - deltaIn = " + deltaIn + ". speed = " + speed + ". total = " + deltaIn * (speed * baseSpeed));
        float total = deltaIn * (speed * baseSpeed);

        if(total > 650)
        {
            total = 650;
        }

        if(total < -650)
        {
            total = -650;
        }

        return total;
    }
}
