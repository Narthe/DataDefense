using UnityEngine;
using System.Collections;

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
			LooseGame();
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

	//affiche l'écran de fin
	public static void LooseGame()
	{
		//afficher l'écran de fin
	}

	//remet le jeu dans son état initial
	public static void ResetGame()
	{
		//remettre toutes les variables à l'état initial
	}

	//augmente l'argent de 1
	public static void IncreaseMoney()
	{
		money++;
	}
}
