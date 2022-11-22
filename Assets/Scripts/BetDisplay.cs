using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BetDisplay : MonoBehaviour
{
    public TextMeshProUGUI betText;
    public Button increaseBetButton;
    public Button decreaseBetButton;

    public int minBet = 2000;
    public int maxBet = 10000;
    public int betIncrement = 2000;
    
    int currBet;

    void Start()
    {
        currBet = maxBet;
        betText.text = currBet.ToString("N0");
    }

    public void IncreaseBet()
    {
        currBet += betIncrement;
        if (currBet >= maxBet)
        {
            currBet = maxBet;
            increaseBetButton.interactable = false;
        }
        if (currBet > minBet)
        {
            decreaseBetButton.interactable = true;
        }

        betText.text = currBet.ToString("N0");
    }
    
    public void DecreaseBet()
    {
        currBet -= betIncrement;
        if (currBet <= minBet)
        {
            currBet = minBet;
            decreaseBetButton.interactable = false;
        }
        if (currBet < maxBet)
        {
            increaseBetButton.interactable = true;
        }

        betText.text = currBet.ToString("N0");
    }
}
