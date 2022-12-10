using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{

    public Card[] playerCards;
    public Card[] cpuCards;

    public RawImage currentPlayerCardImg;
    public RawImage currentCpuCardImg;

    public GameObject playerPointsObject;
    public GameObject cpuPointsObject;
    public GameObject resultObject;
    public GameObject roundObject;
    public GameObject winObject;

    private TextMeshProUGUI playerPointsText;
    private TextMeshProUGUI cpuPointsText;
    private TextMeshProUGUI resultText;
    private TextMeshProUGUI roundText;
    private TextMeshProUGUI winText;

    private int currentPlayerIndex;
    private int currentCpuIndex;

    private int playerPoints;
    private int cpuPoints;

    private int roundNumber;

    private string result;

    private string winner;

    // Start is called before the first frame update
    void Start()
    {
        currentPlayerIndex = 0;
        currentCpuIndex = 0;

        playerPoints = 0;
        cpuPoints = 0;

        roundNumber = 0;

        playerPointsText = playerPointsObject.GetComponent<TextMeshProUGUI>();
        cpuPointsText = cpuPointsObject.GetComponent<TextMeshProUGUI>();
        resultText = resultObject.GetComponent<TextMeshProUGUI>();
        roundText = roundObject.GetComponent<TextMeshProUGUI>();
        winText = winObject.GetComponent<TextMeshProUGUI>();

        SetPlayerImg();
        SetCPUImg();

        result = null;
        winner = null;
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsText.text = "Player Points: " + playerPoints;
        cpuPointsText.text = "CPU Points: " + cpuPoints;
        resultText.text = "Result: " + result;
        roundText.text = "Round " + roundNumber;
        winText.text = "Winner: " + winner;
    }

    public void Draw()
    {
        if (roundNumber < 6)
        {
            roundNumber++;
            GetPlayerCard();
            GetCPUCard();
            Calculate();
        }
        if (roundNumber == 6)
        {
            WhoWon();
        }
    }

    public void GetPlayerCard()
    {
        currentPlayerIndex = Random.Range(1, 7);
        if (playerCards[currentPlayerIndex].used == false)
        {
            SetPlayerImg();
            playerCards[currentPlayerIndex].used = true;
        }
        else
        {
            GetPlayerCard();
        }
    }

    public void GetCPUCard()
    {
        currentCpuIndex = Random.Range(1, 7);
        if (cpuCards[currentCpuIndex].used == false)
        {
            SetCPUImg();
            cpuCards[currentCpuIndex].used = true;
        }
        else
        {
            GetCPUCard();
        }
    }

    public void Calculate()
    {
        int playerValue = playerCards[currentPlayerIndex].cardValue;
        int cpuValue = cpuCards[currentCpuIndex].cardValue;
        if (playerValue > cpuValue)
        {
            playerPoints++;
            result = "Player Wins the Battle!";
        }
        if (playerValue < cpuValue)
        {
            cpuPoints++;
            result = "CPU Wins the Battle!";
        }
        if (playerValue == cpuValue)
        {
            result = "The Battle is a Draw.";
        }

    }

    public void WhoWon()
    {
        if (playerPoints > cpuPoints)
        {
            winner = "Player";
        }
        if (playerPoints < cpuPoints)
        {
            winner = "CPU";
        }
        if (playerPoints == cpuPoints)
        {
            winner = "Draw";
        }
    }

    private void SetPlayerImg()
    {
        if (playerCards[currentPlayerIndex].cardPic != null)
        {
            currentPlayerCardImg.texture = playerCards[currentPlayerIndex].cardPic.texture;
        }
        else
        {
            currentPlayerCardImg.texture = null;
        }
    }

    private void SetCPUImg()
    {
        if (cpuCards[currentCpuIndex].cardPic != null)
        {
            currentCpuCardImg.texture = cpuCards[currentCpuIndex].cardPic.texture;
        }
        else
        {
            currentCpuCardImg.texture = null;
        }
    }

    public void Reset()
    {
        playerPoints = 0;
        cpuPoints = 0;
        winner = null;
        result = null;
        roundNumber = 0;
        int playerReset = 0;
        while (playerReset < 7)
        {
            playerCards[playerReset].used = false;
            playerReset++;
        }
        int cpuReset = 0;
        while (cpuReset < 7)
        {
            cpuCards[cpuReset].used = false;
            cpuReset++;
        }
        currentPlayerIndex = 0;
        SetPlayerImg();
        currentCpuIndex = 0;
        SetCPUImg();
    }
}
