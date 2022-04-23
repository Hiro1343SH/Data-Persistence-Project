using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public TMP_InputField playerNameInputText;
    public TextMeshProUGUI currentPlayerText;

    private bool canStart = false;
    private bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        if (GameController.instance != null)
        {
            if (GameController.instance.playerName == "")
            {
                startText.color = Color.gray;
                currentPlayerText.text = "---";
            }
            else
            {
                currentPlayerText.text = GameController.instance.playerName;
            }
        }
        playerNameInputText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        StartCheck();
    }

    private void StartCheck()
    {
        if (GameController.instance.playerName == "")
        {
            currentPlayerText.text = "---";

            if (playerNameInputText.text != "")
            {
                startText.color = Color.black;
                canStart = true;
            }
            else
            {
                startText.color = Color.gray;
                canStart = false;
            }
        }
        else
        {
            currentPlayerText.text = GameController.instance.playerName;
            canStart = true;
        }
    }

    public void StartClicked()
    {
        if (!isStart)
        {
            if (canStart)
            {
                if (playerNameInputText.text != "")
                {
                    GameController.instance.playerName = playerNameInputText.text;
                }
                isStart = true;
                Invoke(nameof(SceneTransition), 1f);
            }
        }
    }

    private void SceneTransition()
    {
        SceneManager.LoadScene(1);
    }
}
