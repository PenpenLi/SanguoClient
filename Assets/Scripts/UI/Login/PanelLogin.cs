// Author : dandanshih
// Date : 2014/6/12

using UnityEngine;
using System.Collections;

public class PanelLogin : MonoBehaviour 
{
	void Awake ()
	{
		LogMgr.Log ("[PanelLogin] Awake");
		// 把帳號密碼給塞進去
		NGUIUtility.SetInputText ("Input_Account", "dnadan");
		NGUIUtility.SetInputText ("Input_Password", "silveran");
	}

	void OnChildClick (object ChildName)
	{
		LogMgr.Log ("[PanelLogin] OnChildClick, Receive Child {0}", ChildName.ToString());
	}
}
