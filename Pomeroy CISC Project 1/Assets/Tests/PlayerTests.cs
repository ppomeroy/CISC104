using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
    // Tests Player Constructor
    [Test]
    public void PlayerConstructorTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Tests the default values of the constructed player
        Assert.AreEqual(3, newPlayer.playerbp);
        Assert.AreEqual(false, newPlayer.ally);
        Assert.AreEqual(false, newPlayer.voted);
    }

    // Tests Voting functions
    [Test]
    public void VoteTests()
    {
        // Creates new player
        Player newPlayer = new Player();

        newPlayer.Ally(); // Executes the player's Ally vote function
        bool AllyTest = newPlayer.ally; // Creates a new boolean value using the resulting vote
        newPlayer.VoteReset(); // Resets the player's voting status
        newPlayer.Betray(); // Executes the player's Betray vote function
        bool BetrayTest = newPlayer.ally; // Creates a new boolean value using the resulting vote

        // Tests the returned votes
        Assert.AreEqual(true, AllyTest);
        Assert.AreEqual(false, BetrayTest);
    }

    // Tests "Dio" function
    [Test]
    public void DioTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Executes the "Dio" point gain function
        newPlayer.Dio();

        // Tests the resulting points
        Assert.AreEqual(6, newPlayer.playerbp);
    }

    // Tests "Friend" function
    [Test]
    public void FriendTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Executes the "Friend" point gain function
        newPlayer.Friend();

        // Tests the resulting points
        Assert.AreEqual(5, newPlayer.playerbp);
    }

    // Tests "Betrayed" function
    [Test]
    public void BetrayedTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Executes the "Betrayed" point loss function
        newPlayer.Betrayed();

        // Tests the resulting points
        Assert.AreEqual(1, newPlayer.playerbp);
    }

    // Tests "Zero" function
    [Test]
    public void ZeroTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Executes the "Zero" point gain function
        newPlayer.Zero();

        // Tests the resulting points
        Assert.AreEqual(3, newPlayer.playerbp);
    }

    // Tests the reset function
    [Test]
    public void ShiftTest()
    {
        // Creates new player
        Player newPlayer = new Player();

        // Executes a few functions to...
        newPlayer.Dio(); // Add 3 BP
        newPlayer.Friend(); // Add 2 BP
        newPlayer.Dio(); // Add 3 BP
        newPlayer.Ally(); // Set vote to Ally
        newPlayer.Shift(); // Reset the player

        // Tests to see if the values reset
        Assert.AreEqual(3, newPlayer.playerbp);
        Assert.AreEqual(false, newPlayer.voted);
        Assert.AreEqual(false, newPlayer.ally);
    }
}
