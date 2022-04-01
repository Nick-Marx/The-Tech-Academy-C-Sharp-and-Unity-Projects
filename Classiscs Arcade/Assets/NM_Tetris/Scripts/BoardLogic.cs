using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLogic : MonoBehaviour
{
    public static float dropTime = .9f;
    public static float dropAccel = .05f;
    public static int width = 10, height = 20;
    public GameObject[] blocks;
    public Transform[,] grid = new Transform[width, height];
    SceneHandler sceneHandler;
    public static int clearCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        sceneHandler = FindObjectOfType<SceneHandler>();
        SpawnBlock();
    }
    
    public void ClearLines()
    {
        for (int y = 0; y < height; y++)
        {
            if (IsLineComplete(y))
            {
                DestroyLine(y);
                MoveLines(y);
                clearCounter++;
            }
        }
        
    }
    //move all lines above cleared line down
    void MoveLines(int y)
    {
        for (int i = y; i < height - 1; i++)
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[x, i + 1] != null)
                {
                    grid[x, i] = grid[x, i + 1];
                    grid[x, i + 1].gameObject.transform.position -= new Vector3(0, 1, 0);
                    grid[x, i + 1] = null;
                }
                //Debug.Log(x, y, i);

            }
        }
        
    }
    //destroy filled line
    void DestroyLine(int y)
    {
        for (int x = 0; x < width; x++)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }
    //check if a line is filled
    bool IsLineComplete(int y)
    {
        for(int x = 0; x < width; x++)
        {
            if (grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }
    //spawn random block
    public void SpawnBlock()
    {
        float tetroPicker = Random.Range(0, 1f);
        tetroPicker *= blocks.Length;
        Instantiate(blocks[Mathf.FloorToInt(tetroPicker)]);
    }
    public void WinGame()
    {
        if (clearCounter >= 10)
        {
            sceneHandler.ShowCredits();
        }
    }
}
