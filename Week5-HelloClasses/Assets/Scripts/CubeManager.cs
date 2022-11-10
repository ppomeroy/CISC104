using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;

    public GameObject heightTextObject;
    public TextMeshProUGUI heightText { get; set; }
    public GameObject widthTextObject;
    public TextMeshProUGUI widthText { get; set; }
    public GameObject lengthTextObject;
    public TextMeshProUGUI lengthText { get; set; }
    public GameObject volumeTextObject;
    public TextMeshProUGUI volumeText { get; set; }
    public GameObject sidesTextObject;
    public TextMeshProUGUI sidesText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        sidesText = sidesTextObject.GetComponent<TextMeshProUGUI>();

        // Calls constructor and sets values to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        lengthText.text = "Cube Length: " + myCube.GetLength().ToString();
        volumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
        sidesText.text = "Cube Side Length: " + myCube.GetSideLength().ToString();
    }

    public void SlidersChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetLength(lengthSlider.value);
    }
}
