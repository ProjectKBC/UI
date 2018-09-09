using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour {

    Button chara1;
    Button chara2;
    Button chara3;

	// Use this for initialization
	void Start () {
        chara1 = GameObject.Find("charaSelectBtn/chara1").GetComponent<Button>();

        chara2 = GameObject.Find("charaSelectBtn/chara2").GetComponent<Button>();

        chara3 = GameObject.Find("charaSelectBtn/chara3").GetComponent<Button>();
	}
	
    /*
     * カーソルを1P,2P用の２つ用意して一番上にアクティブで配置しておく。
     * キー取得によって、カーソルの位置をカメラと同じように動かしセレクターとして使用する。
     * その時にフラグでもなんでもいいからどの位置にカーソルがあるかを判定するものをつくる。
     * OnClickControllerのような使い方でクリック時の処理を記述し画面にキャラの名前をテキストとして表示させる。
     * キャラ選択完了のフラグを２つつくり、２つともtrueなら次の画面に進ませる
     * 最後に何かの変数に選択したキャラの名前を格納しておいて次の画面でのキャラ表示に使えるようにする。
    */

	// Update is called once per frame
	void Update () {
		
	}
}
