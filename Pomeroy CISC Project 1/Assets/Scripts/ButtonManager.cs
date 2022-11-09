using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    private Player player;
    private Opponent opponent;

    private int roundNumber = 0;

    public GameObject playerVoteObject;
    private TextMeshProUGUI playerVoteText;

    public GameObject oppVoteObject;
    private TextMeshProUGUI oppVoteText;

    public GameObject playerPointsObject;
    private TextMeshProUGUI playerPointsText;

    public GameObject oppPointsObject;
    private TextMeshProUGUI oppPointsText;

    public GameObject roundNumberObject;
    public TextMeshProUGUI roundNumberText;

    private string playerVoted = "X";
    private string oppVoted = "X";

    // Start is called before the first frame update
    void Start()
    {
        // Creates a new instance of Player and Opponent
        player = new Player();
        opponent = new Opponent();

        // Defines the text in the UI
        playerVoteText = playerVoteObject.GetComponent<TextMeshProUGUI>();
        oppVoteText = oppVoteObject.GetComponent<TextMeshProUGUI>();
        playerPointsText = playerPointsObject.GetComponent<TextMeshProUGUI>();
        oppPointsText = oppPointsObject.GetComponent<TextMeshProUGUI>();
        roundNumberText = roundNumberObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // Updates all text in the UI according to the values
        playerVoteText.text = "Player Vote: " + playerVoted;
        oppVoteText.text = "Opponent Vote: " + oppVoted;

        playerPointsText.text = "Player Points: " + player.playerbp;
        oppPointsText.text = "Opponent Points: " + opponent.oppbp;

        roundNumberText.text = "Round Number: " + roundNumber;
    }

    public void PlayerAlly()
    {
        // Executes the Ally function in the Player class, calls the function for the Opponent to vote in the Opponent class, and calls the Results class
        player.Ally();
        OppVote();
        Results(player.ally, opponent.oppAlly);
        // Someone's feeling awfully trusting.
    }

    public void PlayerBetray()
    {
        // Executes the Betray function in the Player class, calls the function for the Opponent to vote in the Opponent class, and calls the Results class
        player.Betray();
        OppVote();
        Results(player.ally, opponent.oppAlly);
        // Can't trust anyone.
    }

    public void OppVote()
    {
        // Executes the Opponent Vote function in the Opponent class
        opponent.VotingTime();
        // Ally...or Betray...I wonder...
    }

    public void Results(bool ally, bool oppAlly)
    {
        // Increases the Round number by one
        roundNumber++;

        // Only continues this way if the Player votes Ally
        if (ally)
        {
            playerVoted = "Ally";
            if (oppAlly)
            {
                // If the Opponent votes Ally as well, it executes the resulting functions in the Player and Opponent classes
                oppVoted = "Ally";
                player.Friend();
                opponent.Friend();
                // Yay altruism!
            }
            if (!oppAlly)
            {
                // If the Opponent votes Betray after the Player votes Ally, it executes the resulting functions in the Player and Opponent classes
                oppVoted = "Betray";
                player.Betrayed();
                opponent.Dio();
                // Oh dear...
            }
        }

        // Only continues this way if the Player votes Betray
        if (!ally)
        {
            playerVoted = "Betray";
            if (oppAlly)
            {
                // If the Opponent votes Ally after the Player votes Betray, it executes the resulting functions in the Player and Opponent classes
                oppVoted = "Ally";
                player.Dio();
                opponent.Betrayed();
                // How cruel!
            }
            if (!oppAlly)
            {
                // If the Opponent votes Betray as well, it executes the resulting functions in the Player and Opponent classes
                oppVoted = "Betray";
                player.Zero();
                opponent.Zero();
                // "Better safe than sorry." 
            }
        }
    }

    public void Shift()
    {
        // Executes the reset functions for the Player and Opponent classes, respectively
        player.Shift();
        opponent.Shift();
        // SHIFT to another timeline, one where things hopefully go better for you.

        // Sets the round number back to zero, and wipes the previous votes
        roundNumber = 0;
        playerVoted = "X";
        oppVoted = "X";
        // This feels...familiar.
    }
}
