using UnityEngine;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour
{
    public static LevelManager _instance;
    public List<LevelData> levels = new List<LevelData>();

    public string currentWord;
    public Sprite currentImage;

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

        currentWord = levels[currentLevel].items[currentItem].word;
        currentImage = levels[currentLevel].items[currentItem].image;
        AppControl._instance.StartLevel();


    }
}
