using System;

public class Player
{
    // Default values for an instance of Player

    public bool ally = false;
    public bool voted = false;

    public int playerbp { get; private set; }

    public Player()
    {
        // If making a new player, sets BP to 3
        playerbp = 3;
    }

    public bool Ally()
    {
        if (!voted)
            // Only continues if the player hasn't voted
        {
            ally = true;
            Voted();
            return ally;
            // Sets the player's vote to Ally, calls the function to say that the player has voted, and returns the vote
        }
        return ally;
    }

    public bool Betray()
    {
        if (!voted)
            // Only continues if the player hasn't voted
        {
            ally = false;
            Voted();
            return ally;
            // Sets the player's vote to Betray, calls the function to say that the player has voted, and returns the vote
        }
        return ally;
    }

    public bool Voted()
    {
        // States that the player has voted
        voted = true;
        return voted;
    }

    public bool VoteReset()
    {
        // Resets the player's voting status
        voted = false;
        return voted;
    }

    public int Dio()
    {
        // Adds 3 points to the player's BP and calls the function to reset their vote
        playerbp += 3;
        VoteReset();
        return playerbp;
        // My my, how devious of you!
    }

    public int Friend()
    {
        // Adds 2 points to the player's BP and calls the function to reset their vote
        playerbp += 2;
        VoteReset();
        return playerbp;
        // You both get something out of it.
    }

    public int Betrayed()
    {
        // Subtracts 2 points from the player's BP and calls the function to reset their vote
        playerbp -= 2;
        VoteReset();
        return playerbp;
        // Be careful from here on out, you can't afford to keep losing points.
    }

    public int Zero()
    {
        // Adds no points to the player's BP and calls the function to reset their vote
        playerbp += 0;
        VoteReset();
        return playerbp;
        // Underwhelming, to be honest.
    }

    public void Shift()
    {
        // Resets the player's voting status, resets their vote, and resets their BP to 3
        voted = false;
        ally = false;
        playerbp = 3;
        // Another timeline jump, hopefully this one goes better for you.
    }
}
