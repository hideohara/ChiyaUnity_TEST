using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour
{

    public GameObject cardPrefab;
    public GameObject cardCursor;

    //�r���h���m�F�p�e�L�X�g�I�u�W�F�N�g


    private GameObject[] card = new GameObject[12];
    public GameObject Canvas1;

    public Sprite sp1;

    int cardTotal = 0;

    float cursorX = 0;
    float cursorY = 0;
    float cursorZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        cursorX = 10.0f; cursorY = 30.0f; cursorZ = 0.0f;
        cardCursor = Instantiate(cardCursor,
            new Vector3(cursorX, cursorY,cursorZ),
            Quaternion.identity);
        cardCursor.transform.parent = Canvas1.transform;
        //cardCursor.transform.SetParent(transform, false);
        cardCursor.transform.localScale =
            new Vector3(0.7f, 0.7f, 0.7f);
        cardCursor.SetActive(true);

        cardTotal = 0;
        

        // �R���e�i���琶�����Ĕz��ɓo�^
        for (int i = 0; i < 6; i++)
        {
            card[i] = Instantiate(cardPrefab,
                new Vector3(680, -100, 0),
                                Quaternion.identity);
            card[i].transform.parent
                = Canvas1.transform;
            card[i].transform.localScale
                = new Vector3(60.0f, 60.0f, 60.0f);
            

            card[i].SetActive(true);
            cardTotal++;
        }

        for(int i = 1; i < 6; i++)
        {
            card[i].transform.localPosition =
                new Vector3((-294/*�t�@�C���̑傫��*/
                - 35/*�ǂ̂��炢���炷��*/) 
                * 0.6f/*�X�P�[��������*/
                * i + 380/*��_*/, -340, 0);
        }

        if (SceneManager.GetActiveScene().name
            == "SampleScene")
        {
            for (int i = 6; i < 12; i++)
            {
                card[i] = Instantiate(cardPrefab,
                    new Vector3(-680, 180, 0),
                                    Quaternion.identity);
                card[i].transform.parent
                = Canvas1.transform;
                card[i].transform.localScale
                    = new Vector3(45.0f, 45.0f, 45.0f);
                card[i].SetActive(true);
                cardTotal++;
            }

            for (int i = 7; i < 12; i++)
            {
                card[i].transform.localPosition =
                    new Vector3((294/*�t�@�C���̑傫��*/
                    + 55/*�ǂ̂��炢���炷��*/)
                    * 0.45f/*�X�P�[��������*/
                    * (i - 6) - 380/*��_*/, 345, 0);

                card[i].SetActive(true);
            }
        }

        // �z����g�p���ĕύX
        // �摜��ύX

        for (int i = 0; i < cardTotal; i++)
        {
            SpriteRenderer s = card[i].GetComponent<SpriteRenderer>();
            s.sprite = sp1;
        }

        //CardData cardData = new CardData(
        //    "�҃v�b�V��", "��", "����", 5, 1, 2, 4, 3,
        //    false, false, false, false, "", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            
        }
        if (Input.GetKey(KeyCode.Return))
        {
            //cardCursor.SetActive(true);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //findCard += 1;
            //if(findCard > cardTotal - 1)
            //{
            //    findCard = 0;
            //}
            //CardSelect();

            cursorX += 0.7f;
            cardCursor.transform.position =
                new Vector3(cursorX, cursorY, cursorZ);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //findCard -= 1;
            //if (findCard < 0)
            //{
            //    findCard = cardTotal;
            //}
            //CardSelect();

            cursorX -= 0.7f;
            cardCursor.transform.position =
                new Vector3(cursorX, cursorY, cursorZ);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            cursorY += 0.7f;
            cardCursor.transform.position =
                new Vector3(cursorX, cursorY, cursorZ);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            cursorY -= 0.7f;
            cardCursor.transform.position =
                new Vector3(cursorX, cursorY, cursorZ);
        }

        //for(int i = 0; i < cardTotal; i++)
        //{
        //    if(i <= 6)
        //    {
        //        card[i].transform.localScale
        //        = new Vector3(60.0f, 60.0f, 60.0f);
        //    }

        //    if(i >= 7)
        //    {
        //        card[i].transform.localScale
        //            = new Vector3(45.0f, 45.0f, 45.0f);
        //    }
        //}
    }



    /// <summary>
    /// �֐��p�G���A
    /// </summary>

    public void CardSelect()
    {
        //card[findCard].transform.localScale
        //    = new Vector3(60.3f, 60.3f, 60.3f);
        //cardSelectMode = 1;
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cursor")
        {
            Debug.Log("�A�^�b�N");
            for (int i = 0; i < cardTotal; i++)
            {
                card[i].transform.localScale
                = new Vector3(61.3f, 61.3f, 61.3f);
            }
        }
    }
}

///�N���X�p�G���A
///
//public class CardData : MonoBehaviour
//{
//    protected GameObject CardObj;
//    protected string cardName = "";
//    protected string cardErement = "";
//    protected string cardKind = "";
//    //protected  cardAbility = ;
//    protected int cardAP = 0;
//    protected int cardFRPL = 0;//�D���x���Z���x��:FavorabilityRatingPlusLevel
//    protected int cardMentalInfluence = 0;
//    protected int cardHP = 0;
//    protected int cardCC = 0;//�����␳:CompatibilityCorrection
//    protected bool cardSelectBefore = false;
//    protected bool cardSelectAfter = false;
//    protected bool cardAttackingStatus = false;
//    protected bool cardAttackedStatus = false;
//    //protected ���ʓK�p��Ԕ���
//    protected string cardInformationStatus = "";//��ԕt�^�ꗗ
//    protected float cardStateTransition = 0.1f;//��ԑJ�ڔ���
//    /*0.1(�f�b�L��),
//     * 0.2(�f�b�L�\),
//     * 0.3(�f�b�L�����̂ݓ��e���������),
//     * 1.1(��D��),
//     * 1.2(��D�\),
//     * 2.1(�t�B�[���h����),
//     * 2.2(�t�B�[���h�ҋ@),
//     * 3(��n)*/

//    public CardData(
//        string cardName,
//        string cardErement,
//        string cardKind,
//        int cardAP,
//        int cardFRPL,
//        int cardMentalInfluence,
//        int cardHP,
//        int cardCC,
//        bool cardSelectBefore,
//        bool cardSelectAfter,
//        bool cardAttackingStatus,
//        bool cardAttackedStatus,
//        string cardInformationStatus,
//        float cardStateTransition)
//    {
//        this.cardName = cardName;
//        this.cardErement = cardErement;
//        this.cardKind = cardKind;
//        this.cardAP = cardAP;
//        this.cardFRPL = cardFRPL;

//        this.cardFRPL &= ~cardFRPL;//?
//        this.cardFRPL |= cardFRPL;//?
//        this.cardFRPL += cardFRPL;//?
//        this.cardFRPL -= cardFRPL;//?

//        this.cardMentalInfluence = cardMentalInfluence;

//        this.cardMentalInfluence |= cardMentalInfluence;//?

//        this.cardHP = cardHP;
//        this.cardCC = cardCC;
//        this.cardSelectBefore = cardSelectBefore;
//        this.cardAttackedStatus = cardAttackedStatus;
//        this.cardInformationStatus = cardInformationStatus;
//        this.cardStateTransition = cardStateTransition;
//    }

//    public string GetName()
//    {
//        return cardName;
//    }

//    public void Attack()
//    {
//        cardAttackingStatus = true;
//        Debug.Log("�U�������I\n");
//    }
//}
