// Author : dandanshih
// Date : 2014/6/12

using UnityEngine;
using System.Collections;

// 用來設定 Unity 屬性的功能
public class UnityProperty : MonoBehaviour 
{
	// 是否會被刪除
	public bool IsDestroy = true;
	// 在 Awake 時做設定
	void Awake ()
	{
		if (IsDestroy == false)
		{
			DontDestroyOnLoad (this.gameObject);
		}
	}
}
