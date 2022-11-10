using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube
{
    private float height;
    private float width;
    private float length;

    public Cube()
    {
        // The default values for the new Cube
        height = 0f;
        width = 0f;
        length = 0f;
    }

    public Cube(float newHeight, float newWidth, float newLength)
    {
        // Tests for positive numbers before setting the new values

        if(newHeight > 0f)
        {
            height = newHeight;
        }
        if(newWidth > 0f)
        {
            width = newWidth;
        }
        if(newLength > 0f)
        {
            length = newLength;
        }
    }

    public float GetVolume()
    {
        // Calculates and returns the volume
        return height * width * length;
    }

    public float GetSideLength()
    {
        // Calculate and returns the sum of the lengths of the sides
        return (4 * height) + (4 * width) + (4 * length);
    }

    public float GetHeight()
    {
        // Returns the height
        return height;
    }

    public void SetHeight(float newHeight)
    {
        // Sets the height to the updated value
        height = newHeight;
    }

    public float GetWidth()
    {
        // Returns the width
        return width;
    }

    public void SetWidth(float newWidth)
    {
        // Sets the width to the updated value
        width = newWidth;
    }

    public float GetLength()
    {
        // Returns the length
        return length;
    }

    public void SetLength(float newLength)
    {
        // Sets the length to the updated value
        length = newLength;
    }
}
