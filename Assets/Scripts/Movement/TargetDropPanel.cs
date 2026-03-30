using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TargetDropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;
    int answerLetterCount;


    void Start()
    {
        answerLetterCount = 3;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }

        StartCoroutine((FindChildBlock()));
    }

    IEnumerator FindChildBlock()
    {
        yield return new WaitForSeconds(0.1f);
        int _currentLevel = LevelManager._instance.currentLevel;
        string _currentWord = LevelManager._instance.CurrentWord;

        //replace lettera with current correct letter
        if (gameObject.name == "Target01")
        {
            if (gameObject.transform.GetChild(0).gameObject.name.ToUpper() == _currentWord[0].ToString().ToUpper())
            {
                AppControl.answerCounter++;
            }
        }

        else if (gameObject.name == "Target02")
        {
            if (gameObject.transform.GetChild(0).gameObject.name.ToUpper() == _currentWord[1].ToString().ToUpper())
            {
                AppControl.answerCounter++;
            }
        }

        else if (gameObject.name == "Target03")
        {
            if (gameObject.transform.GetChild(0).gameObject.name.ToUpper() == _currentWord[2].ToString().ToUpper())
            {
                AppControl.answerCounter++;
            }
        }

        switch (LevelManager._instance.currentLevel)
        {
            case 0:
                if (AppControl.answerCounter == 3)
                {
                    AppControl.answerCounter = 0;
                    var appControlScript = GameObject.Find("AppControl").GetComponent<AppControl>();
                    appControlScript.NextQuestion();
                }
                break;
            case 1:
                if (AppControl.answerCounter == 4)
                {
                    AppControl.answerCounter = 0;
                    var appControlScript = GameObject.Find("AppControl").GetComponent<AppControl>();
                    appControlScript.NextQuestion();
                }
                break;
            case 2:
                if (AppControl.answerCounter == 5)
                {
                    AppControl.answerCounter = 0;
                    var appControlScript = GameObject.Find("AppControl").GetComponent<AppControl>();
                    appControlScript.NextQuestion();
                }
                break;
        }
    }
}
