using System;

public class Opponent
{
    // Default values for an instance of Opponent

    public bool oppAlly = false;
    public bool oppVoted = false;

    public int oppbp { get; private set; }

    public Opponent()
    {
        // If making a new opponent, sets BP to 3
        oppbp = 3;
    }
    
    public bool VotingTime()
    {
        if (!oppVoted)
            // Only continues if the opponent has not voted during the current round
            {
            Random rng = new Random();
            int oppVote = rng.Next(2); // Generates a random number to decide the opponent's vote
            if (oppVote == 0)
                // Only continues if the generated number is 0
                {
                oppAlly = true;
                Voted();
                return oppAlly;
                // Sets the opponent's vote to Ally, calls the function to say that the opponent has voted, and returns the vote
            }
            if (oppVote == 1)
                // Only continues if the generated number is 1
            {
                oppAlly = false;
                Voted();
                return oppAlly;
                // Sets the opponent's vote to Betray, calls the function to say that the opponent has voted, and returns the vote
            }
        }
        return oppAlly;
    }

    public bool Voted()
    {
        // States that the opponent has voted
        oppVoted = true;
        return oppVoted;
    }

    public bool VoteReset()
    {
        // Resets the opponent's voting status
        oppVoted = false;
        return oppVoted;
    }

    public int Dio()
    {
        // Adds 3 points to the opponent's BP and calls the function to reset their vote
        oppbp += 3;
        VoteReset();
        return oppbp;
        // Don't trust anyone, just get out of here. That's the mission.
    }

    public int Friend()
    {
        // Adds 2 points to the opponent's BP and calls the function to reset their vote
        oppbp += 2;
        VoteReset();
        return oppbp;
        // Maybe making some friends here will help you get out.
    }

    public int Betrayed()
    {
        // Subtracts 2 points from the opponent's BP and calls the function to reset their vote
        oppbp -= 2;
        VoteReset();
        return oppbp;
        // How dare they betray you!? Don't make this mistake again.
    }

    public int Zero()
    {
        // Adds no points to the opponent's BP and calls the function to reset their vote
        oppbp += 0;
        VoteReset();
        return oppbp;
        // Seems like the player couldn't trust you either.
    }

    public void Shift()
    {
        // Resets the opponent's voting status, resets their vote, and resets their BP to 3
        oppVoted = false;
        oppAlly = false;
        oppbp = 3;
        // The player claims to have deja vu, let's just ignore that.
    }
}
