using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Presenter : MonoBehaviour
{
    [SerializeField] WordGenerater wordGenerater;
    [SerializeField] View view;

    void Awake()
    {
        wordGenerater.CurrentWord.Subscribe(word => view.ChangeText(word));
        view.OnClickAsObservable.Subscribe(_ => wordGenerater.GenerateWord());
    }
}
