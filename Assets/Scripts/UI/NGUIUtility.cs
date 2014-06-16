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

	#region 和InputText的互動

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

	#endregion

	#region UI的操作行為

	static Dictionary<string, Vector2> dictOldPosition = new Dictionary<string, Vector2> ();
	public static void ShowUI (object UI)
	{
		string UIName = "";
		GameObject UIObject = null;
		if (UI is string)
		{
			UIName = UI as string;
			UIObject = GameObject.Find (UIName);
		}
		else
		{
			UIObject = UI as GameObject;
			UIName = UIObject.name;
		}
		Vector2 Old = new Vector2 (0, 0);
		// 透過 HideUI 的, 可以指定特別位置, 不然就是存放在 (0, 0)
		if (dictOldPosition.ContainsKey (UIName))
		{
			Old = dictOldPosition[UIName];
		}
		UIObject.gameObject.transform.localPosition = new Vector3 (Old.x, Old.y, UIObject.gameObject.transform.localPosition.z);
	}

	public static void HideUI (object UI)
	{
		string UIName = "";
		GameObject UIObject = null;
		if (UI is string)
		{
			UIName = UI as string;
			UIObject = GameObject.Find (UIName);
		}
		else
		{
			UIObject = UI as GameObject;
			UIName = UIObject.name;
		}
		Vector3 Pos = UIObject.gameObject.transform.localPosition;
		Vector2 Old = new Vector2 (Pos.x, Pos.y);
		dictOldPosition[UIName] = Old;
		Vector3 NewPos = new Vector3 (2000, 2000);
		UIObject.gameObject.transform.localPosition = new Vector3 (NewPos.x, NewPos.y, Pos.z);
	}

	#endregion
}
