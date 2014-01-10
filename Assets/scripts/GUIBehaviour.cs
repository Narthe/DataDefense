using UnityEngine;
using System.Collections;

public class GUIBehaviour : MonoBehaviour
{
	public Rect labelPosition;
	string labelText;
	public GUIStyle labelStyle;
	int score = 0;
	
	//Set labelPosition public so it can be changed in inspector (editor). 
	
	void Update()
	{
		labelText = "100";
	}
	
	void OnGUI()
	{
		GUI.Label(labelPosition, labelText, labelStyle);
	}
}