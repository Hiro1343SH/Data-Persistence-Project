using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public Text bestScoreText;
    private int bestScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        bestScore = GameController.instance.bestScore;
        SetBestScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (bestScore != GameController.instance.bestScore)
        {
            bestScore = GameController.instance.bestScore;
            SetBestScore();
        }
    }

    private void SetBestScore()
    {
        string bestPlayer = GameController.instance.bestPlayerName;
        if (bestPlayer == "") bestPlayer = "Name";

        bestScoreText.text = "Best Score : " + bestPlayer + " : " + bestScore.ToString();
    }
}
