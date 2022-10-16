using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTilter : MonoBehaviour
{
    // Maximum tilt is in radians.
    // We can use this static value Mathf.Deg2Rad to convert a degree value to one in radians
    private float maximumXTilt = 10 * Mathf.Deg2Rad;
    private float maximumZTilt = 10 * Mathf.Deg2Rad;

    // Start is called before the first frame update
    void Start()
    {
        // This function could be removed as nothing special happens here currently.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if (gameObject.transform.rotation.x < maximumXTilt)
            {
                gameObject.transform.Rotate(.1f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (gameObject.transform.rotation.x > -maximumXTilt) //This occurs only if above the minimum rotation.
            {
                gameObject.transform.Rotate(-.1f, 0, 0); //Rotates the object down.
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.rotation.z < maximumZTilt) //This occurs only if below the maximum rotation.
            {
                gameObject.transform.Rotate(0, 0, .1f); // Rotates the object left.
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.rotation.z > -maximumZTilt)
            {
                gameObject.transform.Rotate(0, 0, -.1f);
            }
        }
    }
}
