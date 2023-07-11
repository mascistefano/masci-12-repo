using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Punteggio : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            score = score + 100;
            scoreText.text = score.ToString();
        }
    }
}
