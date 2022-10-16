using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfaceController : MonoBehaviour
{
    public GameObject value1GameObject;
    public GameObject value2GameObject;

    TextMeshPro value1Text;
    TextMeshPro value2Text;

    private int value1;
    private int value2;

    // Start is called before the first frame update
    void Start()
    {
        value1Text = value1GameObject.GetComponent<TextMeshPro>();
        value2Text = value2GameObject.GetComponent<TextMeshPro>();

        value1 = 0;
        value2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        value1Text.text = value1.ToString();
        value2Text.text = value2.ToString();
    }

    public void MyButton1()
    {
        value1 += 100;
    }

    public void MyButton2()
    {
        value2 = value1 + 50;
    }

    public void MyButton3()
    {
        value2 /= 3;
    }

    public void YourButton1()
    {
        value2 = value1 - 30; //Takes value1 and subtracts 30, then stores it as value2.
    }

    public void YourButton2()
    {
        value1 *= 200; //Multiplies the current value1 by 200 and stores it as the new value1.
    }

    public void YourButton3()
    {
        value2 = value1 / 2; //Divides value1 by 2, then stores it as value2.
    }
}
