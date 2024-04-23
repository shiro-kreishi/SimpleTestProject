using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = MathF.Round(player.position.z).ToString();
    }
}
