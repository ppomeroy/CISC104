using System;

public class Opponent
{
    public bool oppAlly = false;
    public bool oppVoted = false;

    private int oppbp = 3;
    
    public bool VotingTime()
    {
        if (!oppVoted)
            {
            Random rng = new Random();
            int oppVote = rng.Next(2);
            if (oppVote == 0)
                {
                oppAlly = true;
                Voted();
                return oppAlly;
            }
            if (oppVote == 1)
                {
                oppAlly = false;
                Voted();
                return oppAlly;
            }
        }
        return oppAlly;
    }

    public bool Voted()
    {
        oppVoted = true;
        return oppVoted;
    }

    public bool VoteReset()
    {
        oppVoted = false;
        return oppVoted;
    }

    public int Dio()
    {
        oppbp += 3;
        VoteReset();
        return oppbp;
    }

    public int Friend()
    {
        oppbp += 2;
        VoteReset();
        return oppbp;
    }

    public int Betrayed()
    {
        oppbp -= 2;
        VoteReset();
        return oppbp;
    }

    public int Zero()
    {
        oppbp += 0;
        VoteReset();
        return oppbp;
    }

    public void Shift()
    {
        oppVoted = false;
        oppAlly = false;
        oppbp = 3;
    }
}
