using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class WordGenerater : MonoBehaviour
{
    [SerializeField] string[] words;

    ReactiveProperty<string> currentWord = new ReactiveProperty<string>("Hello");

    public IReactiveProperty<string> CurrentWord
    {
        get => currentWord;
    }

    public void GenerateWord()
    {
        int index = UnityEngine.Random.Range(0, words.Length);

        currentWord.Value = words[index];
        Debug.Log("ワードを生成しました");
    }
}
