// Author : dandanshih
// Date : 2014/6/12

using UnityEngine;
using System.Collections;

public partial class Const
{
	public static string Input_Account = "Input_Account";
	public static string Input_Password = "Input_Password";
}

public class PanelLogin : MonoBehaviour 
{
	void Awake ()
	{
#if DanDan
		LogMgr.Log ("[Test] Global Macro");
#endif
		LogMgr.Log ("[PanelLogin] Awake");
		// 把帳號密碼給塞進去
		//ClientSaveMgr.SetString (Const.Input_Account, "dandan");
		//ClientSaveMgr.SetString (Const.Input_Password, "silver");
		NGUIUtility.SetInputText (Const.Input_Account, ClientSaveMgr.GetString (Const.Input_Account));
		NGUIUtility.SetInputText (Const.Input_Password, ClientSaveMgr.GetString (Const.Input_Password));
	}

	void OnChildClick (object ChildName)
	{
		LogMgr.Log ("[PanelLogin] OnChildClick, Receive Child {0}", ChildName.ToString());
	}
}
