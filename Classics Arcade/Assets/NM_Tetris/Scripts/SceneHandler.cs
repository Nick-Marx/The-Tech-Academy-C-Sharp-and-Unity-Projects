using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    
    public void StartGame()
    {
        
        StartCoroutine(ChangeScene(1));
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        BoardLogic.clearCounter = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        StartCoroutine(ChangeScene(0));
        Cursor.lockState = CursorLockMode.None;
    }
    public void ShowCredits()
    {
        StartCoroutine(ChangeScene(2));
        Cursor.lockState = CursorLockMode.None;
    }

    IEnumerator ChangeScene(int sceneIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneIndex);
    }
}
