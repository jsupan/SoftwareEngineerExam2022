using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Winnings : MonoBehaviour
{
    public TextMeshProUGUI winningsText;

    public int currentWinnings;
    void Start()
    {
        currentWinnings = 0;
        UpdateWinningsText();
    }

    public void UpdateWinnings(int winnings)
    {
        currentWinnings += winnings;
        UpdateWinningsText();
    }

    void UpdateWinningsText()
    {
        winningsText.text = currentWinnings.ToString("N0");
    }
}
