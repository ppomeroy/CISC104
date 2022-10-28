using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    private Player player;
    private Opponent opponent;

    private int roundNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        opponent = new Opponent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerAlly()
    {
        player.Ally();
        Results();
    }

    public void PlayerBetray()
    {
        player.Betray();
        Results();
    }

    public void OppVote()
    {
        opponent.VotingTime();
    }

    public void Results(bool ally, bool oppAlly)
    {
        if (ally)
        {
            OppVote();
            if (oppAlly)
            {
                player.Friend();
                opponent.Friend();
            }
            if (!oppAlly)
            {
                player.Betrayed();
                opponent.Dio();
            }
        }

        if (!ally)
        {
            OppVote();
            if (oppAlly)
            {
                player.Dio();
                opponent.Betrayed();
            }
            if (!oppAlly)
            {
                player.Zero();
                opponent.Zero();
            }
        }
    }

    //public void AmbidexGame()
    //{
    //    roundNumber++;

    //}

    public void Shift()
    {
        player.Shift();
        opponent.Shift();

        roundNumber = 1;
    }
}
