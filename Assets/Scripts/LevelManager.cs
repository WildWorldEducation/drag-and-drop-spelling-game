using UnityEngine;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Linq;


public class LevelManager : MonoBehaviour
{
    public static LevelManager _instance;

    public string CurrentWord { get => levels[currentLevel].items[currentItem].word; }
    public Sprite CurrentImage { get => levels[currentLevel].items[currentItem].image; }

    public List<LevelData> levels = new List<LevelData>();


    public int currentLevel = 0;
    public int currentItem = 0;


    void Awake()
    {
        _instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLevel = 0;
        currentItem = 0;
        if (levels == null) return;

        AppControl._instance.StartLevel();


    }

    public void NextLevel()
    {
        if (currentLevel == 0)
        {
            if (currentItem < levels[currentLevel].items.Count()-1)
                currentItem++;
            else
            {
                if (currentLevel < levels.Count)
                {
                    currentLevel++;
                    currentItem = 0;
                }
            }
        }

    

        
}
}