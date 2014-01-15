using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public static class GameGlobals 
{
	//données du joueur(vie)
	public static int data;
	//données corrompues
	public static int corruptedData;
	//argent du joueur
	public static int money;
	//score du joueur
	public static int score;

	//décrémente le nombre de données du joueur
	public static void DecreaseData()
	{
		data--;
		if(data == 0)
		{
			//LooseGame();
		}
	}

	//récupération des données corrompues
	public static void BackData()
	{
		if(corruptedData != 0)
		{
			data += Mathf.CeilToInt(corruptedData * 1/2);
			corruptedData = corruptedData - Mathf.CeilToInt(corruptedData * 1/2);
		}
	}

	//augmente le score de 1
	public static void ChangeScore()
	{
		score++;
	}
=======
public class GameGlobals : MonoBehaviour {
>>>>>>> 22b7bfc096ab1505670f76a12014e9cd5c3ece21

	public static int dataLeft;
	public static int gold;
	public static int score;
}
