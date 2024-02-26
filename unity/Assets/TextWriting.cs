using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriting : MonoBehaviour
{
    public MessageManager MessageManager;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cotest");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    IEnumerator Skip()
    {
        while (MessageManager.playing) yield return 0;
        while (!MessageManager.IsPushedKey()) yield return 0;
    }

    // 文章を表示させる
    IEnumerator Cotest()
    {
        MessageManager.DrawText("ナレーション");
        yield return StartCoroutine("Skip");

        MessageManager.DrawText("名前", "AがBに話しかける会話");
        yield return StartCoroutine("Skip");

    }
}
