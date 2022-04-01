using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject GameOverMenuUI;
    


    // Update is called once per frame
    void Update()
    {
        GameObject[] allTargets = GameObject.FindGameObjectsWithTag("Target");

        int counter = 0;
        foreach (GameObject target in allTargets)
        {
            if (!target.activeInHierarchy)
            {
                counter++;
            }
        }
        if (counter == allTargets.Length)
        {
            Pause();
        }
    }


    void Pause()
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
