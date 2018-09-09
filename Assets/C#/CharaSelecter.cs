using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSelecter : MonoBehaviour
{
    GameObject selecter1;
    GameObject selecter2;
    GameObject selecter3;
    GameObject selecter4;
    GameObject selecter5;
    GameObject selecter6;
    int count1 = 0;
    int count2 = 0;

    // Use this for initialization
    void Start()
    {
        selecter1 = GameObject.FindWithTag("selecter1");
        selecter2 = GameObject.FindWithTag("selecter2");
        selecter3 = GameObject.FindWithTag("selecter3");
        selecter4 = GameObject.FindWithTag("selecter4");
        selecter5 = GameObject.FindWithTag("selecter5");
        selecter6 = GameObject.FindWithTag("selecter6");
        selecter2.SetActive(false);
        selecter3.SetActive(false);
        selecter5.SetActive(false);
        selecter6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        //1Pのキー設定
        if (Input.GetKeyDown(KeyCode.S))
        {
            count1++;
            buffer1P(count1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            count1--;
            buffer1P(count1);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            if (selecter1.activeSelf) print("1P-chara1");
            else if (selecter2.activeSelf) print("1P-chara2");
            else if (selecter3.activeSelf) print("1P-chara3");
            else print("これがでたら終末");
        }

        //2Pのキー設定
        if (Input.GetKeyDown(KeyCode.K))
        {
            count2++;
            print(count2);
            buffer2P(count2);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            count2--;
            print(count2);
            buffer2P(count2);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selecter4.activeSelf) print("2P-chara1");
            else if (selecter5.activeSelf) print("2P-chara2");
            else if (selecter6.activeSelf) print("2P-chara3");
            else print("これがでたら終末");
        }

    }

    void buffer1P(int counts)
    {
        switch (counts % 3)
        {
            case 0:
                selecter1.SetActive(true);
                selecter2.SetActive(false);
                selecter3.SetActive(false);
                break;
            case 1:
                selecter1.SetActive(false);
                selecter2.SetActive(true);
                selecter3.SetActive(false);
                break;
            case 2:
                selecter1.SetActive(false);
                selecter2.SetActive(false);
                selecter3.SetActive(true);
                break;
        };
    }

    void buffer2P(int counts){
        switch (counts % 3)
        {
            case 0:
                selecter4.SetActive(true);
                selecter5.SetActive(false);
                selecter6.SetActive(false);
                break;
            case 1:
                selecter4.SetActive(false);
                selecter5.SetActive(true);
                selecter6.SetActive(false);
                break;
            case 2:
                selecter4.SetActive(false);
                selecter5.SetActive(false);
                selecter6.SetActive(true);
                break;
        };
    }
}