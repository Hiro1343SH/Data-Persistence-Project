using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClearButton : MonoBehaviour
{
    private bool isClicked = false;

    public void ClearButtonClicked()
    {
        if (!isClicked)
        {
            Invoke(nameof(ClearRecord), 0.5f);
            isClicked = true;
        }
    }

    private void ClearRecord()
    {
        GameController.instance.ClearRecord();
        SceneManager.LoadScene(0);
    }
}
