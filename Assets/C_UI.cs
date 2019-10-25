using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class C_UI: MonoBehaviour
{
	public Text playerName;

	public void goOnclick(Text enterText) {       // 點擊返回鍵，進入遊戲
		C_value.IDnum = enterText.text;
        SceneManager.LoadScene("UI-feedback");
    }

	public void editOnclick(Text enterText) {       // 點擊編輯鍵，進入編輯畫面
		C_value.IDnum = enterText.text;
        SceneManager.LoadScene("UI-edit");
    }

	public void backOnclick(Text enterText) {       // 點擊離開鍵，離開遊戲
		C_value.IDnum = enterText.text;

		if (Directory.Exists("Assets/GameData/" + C_value.IDnum)){
			playerName.text = "已有紀錄";
		}
	}

    void Update() {
		
	}
}
