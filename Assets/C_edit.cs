using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class C_edit : MonoBehaviour {

	public Text gamenameText;
	public Text locateText;
	public Text degreeText;
	public Dropdown mode;
	public Dropdown level;

	public Text test;

	public void questionOnclick() {       // 點擊問號鍵，進入說明畫面
		SceneManager.LoadScene("UI-question");
	}

	public void saveOnclick() {       // 點擊返回鍵，儲存並回到初始畫面
		C_value.Gname = gamenameText.text;
		C_value.locate = locateText.text;
		C_value.degree = degreeText.text;

		SceneManager.LoadScene("UI");
	}

	public void resetOnclick() {       // 點擊重置鍵，畫面重新
		SceneManager.LoadScene("UI-edit");
	}

	public void backOnclick() {       // 點擊重置鍵，畫面重新
		SceneManager.LoadScene("UI");
	}

	public void modeOnselect(int index){
		C_value.mode = index;					// 紀錄使用者所選擇之模式
	}

	public void levelOnselect(int index){
		C_value.level = index + 4;					// 紀錄使用者所選擇之關卡數
	}
}
