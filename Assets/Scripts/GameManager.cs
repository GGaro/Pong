using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager main;

    [Header("Player References")]
    [SerializeField] PlayerControll playerOne;
    [SerializeField] PlayerControll playerTwo;
    [Header("Text References")]
    [SerializeField] TextMeshProUGUI playerOneText;
    [SerializeField] TextMeshProUGUI playerTwoText;
    [Header("Ball Reference")]
    [SerializeField] BallScript Ball;

    int PlayerOneScoreNumber = 0;
    int PlayerTwoScoreNumber = 0;

    private void Awake()
    {
        main = this;
    }

    public void PlayerOneScore()
    {
        PlayerTwoScoreNumber++;
        playerTwoText.text = PlayerTwoScoreNumber.ToString();
        ResetAll();
    }

    public void PlayerTwoScore()
    {
        PlayerOneScoreNumber++;
        playerOneText.text = PlayerOneScoreNumber.ToString();
        ResetAll();
    }

    private void ResetAll()
    {
        Ball.Reset();
        playerOne.Reset();
        playerTwo.Reset();
    }
}
