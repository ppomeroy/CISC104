using System;

public class Player
{
    public bool ally = false;
    public bool voted = false;

    private int playerbp = 3;

    //public int playerBP { get; private set; }

    //public Player()
    //{
    //    playerBP = 0;
    //}

    public bool Ally()
    {
        if (!voted)
        {
            ally = true;
            Voted();
            return ally;
        }
        return ally;
    }

    public bool Betray()
    {
        if (!voted)
        {
            ally = false;
            Voted();
            return ally;
        }
        return ally;
    }

    public bool Voted()
    {
        voted = true;
        return voted;
    }

    public bool VoteReset()
    {
        voted = false;
        return voted;
    }

    public int Dio()
    {
        playerbp += 3;
        VoteReset();
        return playerbp;
    }

    public int Friend()
    {
        playerbp += 2;
        VoteReset();
        return playerbp;
    }

    public int Betrayed()
    {
        playerbp -= 2;
        VoteReset();
        return playerbp;
    }

    public int Zero()
    {
        playerbp += 0;
        VoteReset();
        return playerbp;
    }

    public void Shift()
    {
        voted = false;
        ally = false;
        playerbp = 3;
    }
}
