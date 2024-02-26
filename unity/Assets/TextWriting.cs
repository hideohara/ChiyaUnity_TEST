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

    // ���͂�\��������
    IEnumerator Cotest()
    {
        MessageManager.DrawText("�i���[�V����");
        yield return StartCoroutine("Skip");

        MessageManager.DrawText("���O", "A��B�ɘb���������b");
        yield return StartCoroutine("Skip");

    }
}
