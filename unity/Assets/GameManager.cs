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
    //    Debug.Log("�V�[���ڍs");
    //}

    //�V�[���ڍs
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);

        Debug.Log("�V�[���ڍs");
    }

    //�Q�[���I��:�{�^������Ăяo��
    public void EndGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
        #else

            Application.Quit();//�Q�[���v���C�I��
        #endif
    }

    public void SaddLifeCountP()
    {
        PlayerLife = PlayerLife - 1;
        textComponent1.text = "���C�t:" + PlayerLife;
    }

    public void SaddLifeCountE()
    {
        EnemyLife = EnemyLife - 1;
        textComponent2.text = "���C�t:" + EnemyLife;
    }
}