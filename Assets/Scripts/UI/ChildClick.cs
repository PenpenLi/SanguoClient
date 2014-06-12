// Author : dandnashih
// Date : 2014/6/12

using UnityEngine;
using System.Collections;

// 如果 Child 被做行為要通知 Parent
public class ChildClick : MonoBehaviour 
{
	void OnClick ()
	{
		Debug.Log ("[ChildClick] OnClick");
		// 把資料轉發給 Parent 去做處理
		//SendMessage ("OnChildClick", this.gameObject.transform.parent.gameObject, SendMessageOptions.RequireReceiver);
		this.gameObject.transform.parent.gameObject.SendMessage ("OnChildClick", this.name);
	}
}
