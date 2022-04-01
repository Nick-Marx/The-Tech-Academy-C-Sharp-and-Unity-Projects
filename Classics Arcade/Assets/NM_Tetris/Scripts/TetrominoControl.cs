using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrominoControl : MonoBehaviour
{
    BoardLogic boardLogic;
    bool movable = true;
    public GameObject rig;
    float timer = 0f;
    SceneHandler sceneHandler;
    // Start is called before the first frame update
    void Start()
    {
        boardLogic = FindObjectOfType<BoardLogic>();
        sceneHandler = FindObjectOfType<SceneHandler>();
    }
    void RegisterBlock()
    {
        foreach (Transform subBlock in rig.transform)
        {
            boardLogic.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] = subBlock;
        }
    }
    bool CheckValid()
    {
        foreach (Transform subBlock in rig.transform)
        {
            if(subBlock.transform.position.x >= BoardLogic.width || subBlock.transform.position.x < 0 || subBlock.transform.position.y < 0)
            {
                return false;
            }
            if (subBlock.position.y < BoardLogic.height && boardLogic.grid[Mathf.FloorToInt(subBlock.position.x), Mathf.FloorToInt(subBlock.position.y)] != null)
            {
                return false;
            }
        }
        return true;
    }
    void BlockOut()
    {
        foreach (Transform subBlock in rig.transform)
        {
            if (subBlock.transform.position.y > BoardLogic.height - 1)
            {
                sceneHandler.ShowCredits();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (movable)
        {
            //update timer
            timer += 1 * Time.deltaTime;

            //quickdrop
            if (Input.GetKey(KeyCode.DownArrow) && timer > BoardLogic.dropAccel)
            {
                gameObject.transform.position -= new Vector3(0, 1, 0);
                timer = 0;
                if (!CheckValid())
                {
                    movable = false;
                    gameObject.transform.position += new Vector3(0, 1, 0);
                    RegisterBlock();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.WinGame();
                    BlockOut();
                    boardLogic.SpawnBlock();
                }
            }
            //constant drop
            else if (timer > BoardLogic.dropTime)
            {
                gameObject.transform.position -= new Vector3(0, 1, 0);
                timer = 0;
                if (!CheckValid())
                {
                    movable = false;
                    gameObject.transform.position += new Vector3(0, 1, 0);
                    RegisterBlock();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.ClearLines();
                    boardLogic.WinGame();
                    BlockOut();
                    boardLogic.SpawnBlock();
                }
            }

            //side movement
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position -= new Vector3(1, 0, 0); 
                if (!CheckValid())
                {
                    gameObject.transform.position += new Vector3(1, 0, 0);
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position += new Vector3(1, 0, 0);
                if (!CheckValid())
                {
                    gameObject.transform.position -= new Vector3(1, 0, 0);
                }
            }
            //rotation
            if (Input.GetKeyDown(KeyCode.A))
            {
                rig.transform.eulerAngles -= new Vector3(0, 0, 90);
                if (!CheckValid())
                {
                    rig.transform.eulerAngles += new Vector3(0, 0, 90);
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                rig.transform.eulerAngles += new Vector3(0, 0, 90);
                if (!CheckValid())
                {
                    rig.transform.eulerAngles -= new Vector3(0, 0, 90);
                }
            }
        }
    }
}
