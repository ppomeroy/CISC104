using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCollisionManager : MonoBehaviour
{
    static int ballCollisionCount = 0;
    static int wallCollisionCount = 0;

    private TextMeshPro ballCountText;
    private TextMeshPro wallCountText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ballCountGameObject = GameObject.Find("BallCollisionCount");
        GameObject wallCountGameObject = GameObject.Find("WallCollisionCount");

        ballCountText = ballCountGameObject.GetComponent<TextMeshPro>();
        wallCountText = wallCountGameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        ballCountText.text = "Ball Collision Count: " + ballCollisionCount;
        wallCountText.text = "Wall Collision Count: " + wallCollisionCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            ballCollisionCount++;
        }

        if (collision.gameObject.tag == "Wall") //Occurs if the balls hit the wall
        {
            wallCollisionCount++; //Increases "Wall Collision Count" by 1 for each ball that hits the wall
        }
    }
}
