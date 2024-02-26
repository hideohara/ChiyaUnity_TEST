using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class going : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 200,-50);
        transform.localScale = new Vector3(1, 1, 1);
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //物体のワールド座標を取得
        Vector3 pos = transform.position;
        Vector3 scale = transform.localScale;

        //前に真っ直ぐ飛ぶ
        if(pos.z >=-50)
        {
            pos.z += 0.5f;

            //スケール拡大
            scale.x += 0.3f;
            scale.y += 0.3f;
            scale.z += 0.3f;

            //弾の移動
            transform.position = new Vector3(pos.x, pos.y, pos.z);
            transform.localScale =
                new Vector3(scale.x, scale.y, scale.z);
        }
        //一定距離進んだら消滅
        if (pos.z >= 1500)
        {
            //Destroy(this.gameObject);
            transform.position = new Vector3(0, 200, -50);
            transform.localScale =new Vector3(1, 1, 1);
        }
    }
}
