﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public void backToTitle()
    {
        SceneManager.LoadScene(0);
    }
}
