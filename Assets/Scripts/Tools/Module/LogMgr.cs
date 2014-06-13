/// <summary>
/// Author : dandanshih
/// Date : 2014/6/13
/// Desc : 做寫檔的 Singleton
/// </summary>
// 
using UnityEngine;
using System.Collections;

public class LogMgr
{
	public static void Log (object Msg, params object[] Args)
	{
		string Result = string.Format (Msg.ToString(), Args);
		Debug.Log (Msg);
	}
}
