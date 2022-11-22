using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public Reel[] reel;
    bool startSpin = false;

    public Button spinButton;

    public void Spinner()
    {
        if (!startSpin)
        {
            startSpin = true;
            spinButton.interactable = false;
            StartCoroutine(Spinning());
        }
    }

    IEnumerator Spinning()
    {
        foreach (Reel spinner in reel)
        {
            spinner.spin = true;
        }

        for(int i = 0; i < reel.Length; i++)
        {
            yield return new WaitForSeconds(Random.Range(1,3));
            reel[i].spin = false;
            reel[i].RandomPosition();
        }

        startSpin = false;
        spinButton.interactable = true;
    }
}
