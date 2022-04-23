using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private bool isClicked =false;

    public void BackButtonClicked()
    {
        if (!isClicked)
        {
            Invoke(nameof(SceneTransition), 0.5f);
            isClicked = true;
        }
    }

    private void SceneTransition()
    {
        SceneManager.LoadScene(0);
    }
}
