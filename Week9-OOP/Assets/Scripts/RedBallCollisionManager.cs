using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // The red ball gets bigger when it collides with another object.
        transform.localScale += new Vector3(1, 1, 1);
    }
}

