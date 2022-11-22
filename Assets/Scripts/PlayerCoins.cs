using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public TextMeshProUGUI playerCoinsText;

    public int currentCoins;

    void Start()
    {
        UpdatePlayerCoins();
    }

    public void UpdatePlayerCoins()
    {
        playerCoinsText.text = currentCoins.ToString("N0");
    }
}
