using UnityEngine;
using System.Collections;

public class GUIBehaviour : MonoBehaviour
{
	public Rect scorePosition;
	public Rect goldPosition;
	public Rect dataLeftPosition;
	public Rect goldSpritePosition;
	public Rect sloppySpritePosition;

	public GUIStyle Style;
	string score;
	string gold = "5000";
	string dataLeft = "253";

	string globalScore = "100";

	public Texture2D goldSprite;
	public Texture2D sloppyDiskSprite;

	void Update()
	{
		score = (string)globalScore;
	}
	
	void OnGUI()
	{
		GUI.Label(scorePosition, score, Style);
		GUI.Label(goldPosition, gold, Style);
		GUI.Label(dataLeftPosition, dataLeft, Style);

		GUI.DrawTexture(goldSpritePosition, goldSprite, ScaleMode.ScaleToFit, true, 0.0F);
		GUI.DrawTexture(sloppySpritePosition, sloppyDiskSprite, ScaleMode.ScaleToFit, true, 0.0F);

	}
}