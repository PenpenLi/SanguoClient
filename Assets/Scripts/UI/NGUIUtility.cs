// Author : dandnashih
// Date : 2014/6/12

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NGUIUtility
{
	// 取得老爸的 GameObject
	public static GameObject GetParent (GameObject Child)
	{
		return Child.gameObject.transform.parent.gameObject;
	}

	// 設定 Input 的文字
	public static void SetInputText (object UI, string Text)
	{
		UIInput obj = null;
		if (UI is string)
		{
			obj = GameObject.Find (UI as string).GetComponent<UIInput> ();
		}
		else
		{
			obj = (UI as GameObject).GetComponent<UIInput> ();
		}
		obj.value = Text;
	}

	public static string GetInputText (object UI)
	{
		UIInput obj = null;
		if (UI is string)
		{
			obj = GameObject.Find (UI as string).GetComponent<UIInput>();
		}
		else
		{
			obj = (UI as GameObject).GetComponent<UIInput> ();
		}
		return obj.value;
	}
}
