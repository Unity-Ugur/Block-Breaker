using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int breakableBlocks;
    screenLoader _screenLoader;

    public void Start()
    {
        Application.targetFrameRate = 60;
        _screenLoader = FindObjectOfType<screenLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }
    
    public int GetCountBreakableBlocks()
    {
        return breakableBlocks;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            _screenLoader.LoadNextScene();
        }
    }
}
