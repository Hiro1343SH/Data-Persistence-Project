using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        SetBestScore();
    }

    private void SetBestScore()
    {
        if(GameController.instance.bestScore == 0)
        {
            playerNameText.text = "---";
            bestScoreText.text = "---";
        }
        else
        {
            playerNameText.text = GameController.instance.playerName;
            bestScoreText.text = GameController.instance.bestScore.ToString();
        }
    }
}
