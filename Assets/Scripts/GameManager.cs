using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float mouseSensitivity = 400f;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        // Application.targetFrameRate = 120;
    }
}
