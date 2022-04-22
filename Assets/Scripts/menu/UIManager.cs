using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI startText;

    private string playerName;
    private int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        SetBestScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadData()
    {
        GameController.instance.LoadData();

        playerName = GameController.instance.playerName;
        bestScore = GameController.instance.bestScore;

    }

    private void SetBestScore()
    {
        if(GameController.instance.bestScore == 0)
        {
            playerNameText.text = "-";
            bestScoreText.text = "-";
        }
        else
        {
            playerNameText.text = GameController.instance.playerName;
            bestScoreText.text = GameController.instance.bestScore.ToString();
        }
    }
}
