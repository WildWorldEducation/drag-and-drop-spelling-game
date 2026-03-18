using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppControl : MonoBehaviour
{
    public static AppControl _instance;
    public Image questionImage;
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();
    public static int answerCounter = 0;

    public Transform target1, target2, target3, target4;
    public Transform DParent, OParent, GParent;
    public Transform Parent1, Parent2, Parent3;
    public Transform D, O, G;
    public Transform Block1, Block2, Block3;

    public string firstLetter;
    public string secondLetter;
    public string thirdLetter;
    public string fourthLetter;
    public string fifthLetter;
void Awake()
{
    _instance = this;
}
    void Start()
    {

       // questionImage.sprite = Resources.Load<Sprite>("VocabImages/DOG");

        // use V4 question bank



        // questionImage.sprite = DomesticAnimalQuestionBank.domesticAnimalNameQuestions[1].sprite;
    }


    public void NextQuestion()
    {
        D.SetParent(DParent);
        O.SetParent(OParent);
        G.SetParent(GParent);
        /*
        Block1.SetParent(Parent1);
        Block2.SetParent(Parent2);
        Block3.SetParent(Parent3);*/

        questionImage.sprite = Resources.Load<Sprite>("VocabImages/DUCK");

        target1.localPosition = new Vector3(-150.25f, -120, 0);
        target2.localPosition = new Vector3(-49.5f, -120, 0);
        target3.localPosition = new Vector3(49.5f, -120, 0);
        target4.localPosition = new Vector3(150.25f, -120, 0);
        target4.GetComponent<CanvasGroup>().alpha = 1;
    }
    public void StartLevel()
    {
        questionImage.sprite = LevelManager._instance.currentImage;
        int _level = LevelManager._instance.currentLevel;
        string _word = LevelManager._instance.currentWord;

        Block1 = GameObject.Find(_word[0].ToString().ToUpper()).transform;
        Parent1 = Block1.parent;

        Block2 = GameObject.Find(_word[1].ToString().ToUpper()).transform;
        Parent2 = Block2.parent;

        Block3 = GameObject.Find(_word[2].ToString().ToUpper()).transform;
        Parent3 = Block3.parent;

        if(_level>1)
        { }
        if (_level > 2)
        { }

    }
}
