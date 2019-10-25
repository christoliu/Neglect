using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class C_feedback : MonoBehaviour {

	public void backOnclick() {
		SceneManager.LoadScene("UI");
	}

	// Use this for initialization
	void Start () {

	}
	//public Text Record;
	//public bool hand;
	//recordlist record_ls;

	/*
	 * public void backOnclick() {
		foreach (var QQ in record_ls.item) {
			if (QQ.id == value.IDnum) {
				QQ.clicks = 100;
				QQ.percentage = 200;
			}
		}
		string update_json = JsonUtility.ToJson(record_ls);
		StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/GameJSONData", "myrecord.json"));
		file.Write(update_json);
		file.Close();
		SceneManager.LoadScene("UI");
	}

	// Use this for initialization
	void Start () {
		
		//讀取器
		StreamReader fileReader = new StreamReader(System.IO.Path.Combine("Assets/GameJSONData", "myrecord.json"));
		string check_json = fileReader.ReadToEnd();
		fileReader.Close();

		record_ls = JsonUtility.FromJson<recordlist>(check_json);
		foreach (var QQ in record_ls.item) {
			if (QQ.id == value.IDnum) {
				Record.text = "Congrate!  " + QQ.id + "\n" + "(" + QQ.mode + ", " + QQ.targets + ", " + QQ.sets + ")" + "\n" + "finishTime: 2, 1, 3, 5, 3, 2, 3,";
			}
		}
	}
	*/
}