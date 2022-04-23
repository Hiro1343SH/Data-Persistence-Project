using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuBestScore : MonoBehaviour
{
    public TextMeshProUGUI bestPlayerNameText;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        SetBestScore();
    }

    private void SetBestScore()
    {
        if (GameController.instance.bestScore == 0)
        {
            bestPlayerNameText.text = "---";
            bestScoreText.text = "---";
        }
        else
        {
            bestPlayerNameText.text = GameController.instance.bestPlayerName;
            bestScoreText.text = GameController.instance.bestScore.ToString();
        }
    }

}
