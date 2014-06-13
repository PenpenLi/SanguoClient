// Author : dandnashih
// Date : 2014/6/12

using UnityEngine;
using System.Collections;

// 如果 Child 被做行為要通知 Parent
public class ChildClick : MonoBehaviour 
{
	void OnClick ()
	{
		LogMgr.Log ("[ChildClick] {0} is OnClick", this.name);
		// 把資料轉發給 Parent 去做處理
		GameObject Parent = NGUIUtility.GetParent (this.gameObject);
		Parent.SendMessage ("OnChildClick", this.name, SendMessageOptions.RequireReceiver);
	}
}
