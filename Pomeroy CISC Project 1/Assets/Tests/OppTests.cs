using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class OppTests
{
    // Tests Opponent constructor
    [Test]
    public void OppConstructorTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Tests the default values of the constructed opponent
        Assert.AreEqual(3, newOpp.oppbp);
        Assert.AreEqual(false, newOpp.oppVoted);
        Assert.AreEqual(false, newOpp.oppAlly);
    }

    // Tests the opponent's ally vote
    [Test]
    public void OppAllyTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();
        bool isAlly = false; // Creates a boolean value to store if the opponent's vote is Ally

        while (!isAlly)
            // Repeats until the opponent's voting function returns an Ally vote
            // I don't remember if we've gone over for loops yet but I looked them up because I figured one would work well here
        {
            newOpp.VotingTime(); // Executes the opponent's voting funciton
            if (newOpp.oppAlly) // Only continues if the opponent's vote is Ally
            {
                isAlly = true; // Stores that the opponent's vote is Ally
            }
            else
            {
                isAlly = false; // Stores that the oppeonent's vote is not Ally
            }
        }

        // Tests the resulting vote
        Assert.AreEqual(true, newOpp.oppAlly);
    }

    // Tests the opponent's betray vote
    [Test]
    public void OppBetrayTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();
        bool isBetray = false; // Creates a boolean value to store if the opponent's vote is Betray

        while (!isBetray)
        // Repeats until the opponent's voting function returns an Betray vote
        {
            newOpp.VotingTime(); // Executes the opponent's voting funciton
            if (!newOpp.oppAlly) // Only continues if the opponent's vote is Betray
            {
                isBetray = true; // Stores that the opponent's vote is Betray
            }
            else
            {
                isBetray = false; // Stores that the opponent's vote is not Betray
            }
        }

        // Tests the resulting vote
        Assert.AreEqual(false, newOpp.oppAlly);
    }

    // Tests opponent's "Dio" function
    [Test]
    public void DioTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Executes the opponent's "Dio" point gain fucntion
        newOpp.Dio();

        // Tests the resulting points
        Assert.AreEqual(6, newOpp.oppbp);
    }

    // Tests opponent's "Friend" function
    [Test]
    public void FriendTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Executes the opponent's "Friend" point gain fucntion
        newOpp.Friend();

        // Tests the resulting points
        Assert.AreEqual(5, newOpp.oppbp);
    }

    // Tests opponent's "Betrayed" function
    [Test]
    public void Betrayed()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Executes the opponent's "Betrayed" point loss fucntion
        newOpp.Betrayed();

        // Tests the resulting points
        Assert.AreEqual(1, newOpp.oppbp);
    }

    // Tests opponent's "Zero" function
    [Test]
    public void ZeroTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Executes the opponent's "Zero" point gain fucntion
        newOpp.Zero();

        // Tests the resulting points
        Assert.AreEqual(3, newOpp.oppbp);
    }

    // Tests opponent's reset function
    [Test]
    public void ShiftTest()
    {
        // Creates new opponent
        Opponent newOpp = new Opponent();

        // Executes a few functions to...
        newOpp.Friend(); // Add 2 BP
        newOpp.Dio(); // Add 3 BP
        newOpp.Friend(); // Add 2 BP
        newOpp.VotingTime(); // Returns any voting result
        newOpp.Shift(); // Resets the opponent

        // Tests to see if the values reset
        Assert.AreEqual(3, newOpp.oppbp);
        Assert.AreEqual(false, newOpp.oppAlly);
        Assert.AreEqual(false, newOpp.oppVoted);
    }
}
