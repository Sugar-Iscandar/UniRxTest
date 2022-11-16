using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class View : MonoBehaviour
{
    [SerializeField] Text textTest;
    [SerializeField] Button buttonChange;

    public IObservable<Unit> OnClickAsObservable
    {
        get => buttonChange.OnClickAsObservable();
    }

    public void ChangeText(string newText)
    {
        textTest.text = newText;
    }
}
