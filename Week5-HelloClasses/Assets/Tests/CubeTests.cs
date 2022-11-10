using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTests
{
    // Test the default constructor
    [Test]
    public void CubeConstructorTest()
    {
        // Setup/Act
        Cube defaultCube = new Cube();

        // Assert
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetVolume());
        Assert.AreEqual(0, defaultCube.GetSideLength());
    }

    // Test a 3 x 3 x 4 cuboid
    [Test]
    public void CubeThreeByThreeByFourTest()
    {
        // Setup/Act
        Cube tBTBF = new Cube(3f, 3f, 4f);
        // "tBTBF" is short for "Three by Three by Four"

        // Assert
        Assert.AreEqual(3, tBTBF.GetHeight());
        Assert.AreEqual(3, tBTBF.GetWidth());
        Assert.AreEqual(4, tBTBF.GetLength());
        Assert.AreEqual(36, tBTBF.GetVolume());
        Assert.AreEqual(40, tBTBF.GetSideLength());
    }

    // Test the SetLength method
    [Test]
    public void CubeSetLengthTest()
    {
        // Setup
        Cube newCube = new Cube(2, 3, 4);

        // Act
        newCube.SetLength(5);

        // Assert
        Assert.AreEqual(5, newCube.GetLength());
        Assert.AreEqual(3, newCube.GetWidth());
        Assert.AreEqual(30, newCube.GetVolume());
        Assert.AreEqual(40, newCube.GetSideLength());
    }
}
