using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static Progress Instance;

    public int levelProgress; // Example: current level
    public int score;         // Example: player's score

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveProgress(int level, int score)
    {
        levelProgress = level;
        this.score = score;
    }

    public void LoadProgress(out int level, out int score)
    {
        level = levelProgress;
        score = this.score;
    }

}
