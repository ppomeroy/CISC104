using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public AudioSource vineBoom;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Plays the infamous "Vine Boom" sound effect when the green ball collides with another ball.
        vineBoom.Play();
    }
}

