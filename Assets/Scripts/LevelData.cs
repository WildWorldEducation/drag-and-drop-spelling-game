using UnityEngine;


[System.Serializable]
public class LevelData
{
    public string levelName;
    public LevelItem[] items; // Array of 5 items

}

[System.Serializable]
public class LevelItem
{
    public string word;
    public Sprite image;
}