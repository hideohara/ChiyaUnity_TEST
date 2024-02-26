using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textComponent1;

    public Text textComponent2;

    private int PlayerLife;
    private int EnemyLife;

    // Start is called before the first frame update
    void Start()
    {
        PlayerLife = 10;
        EnemyLife = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    //public void OnClick()
    //{
    //    //ChangeScene("");
    //    Debug.Log("シーン移行");
    //}

    //シーン移行
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);

        Debug.Log("シーン移行");
    }

    //ゲーム終了:ボタンから呼び出す
    public void EndGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
        #else

            Application.Quit();//ゲームプレイ終了
        #endif
    }

    public void SaddLifeCountP()
    {
        PlayerLife = PlayerLife - 1;
        textComponent1.text = "ライフ:" + PlayerLife;
    }

    public void SaddLifeCountE()
    {
        EnemyLife = EnemyLife - 1;
        textComponent2.text = "ライフ:" + EnemyLife;
    }
}