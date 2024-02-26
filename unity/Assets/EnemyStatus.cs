using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    public GameManager gameManager;//’Ç‹L

    // Start is called before the first frame update
    void Start()
    {
        GameObject managerObject = GameObject.Find("Manager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        gameManager.SaddLifeCountE();
    }
}
