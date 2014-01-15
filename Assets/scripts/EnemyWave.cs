using UnityEngine;
using System.Collections;

public class EnemyWave : MonoBehaviour 
{
	//GameObject typeVirus;
	public GameObject virusMalveillant;
	public GameObject versMalveillant;
	public GameObject chevalDeTroieMalveillant;

	private float delay = 0.0f;

	public int numberOfEnemy;
	public int typeOfEnemy;
	public int i = 0;

	void Start () 
	{
	}

	void Update () 
	{
		delay += Time.deltaTime;
		instantiateEnemy(numberOfEnemy, typeOfEnemy);
	}

	/*
	 * Instantiation d'un type de virus 
	 * */
	void instantiateEnemy(int numberOfEnemy, int typeOfEnemy)
	{
		if(delay >= 2)
		{
			if(i <= numberOfEnemy)
			{
				if(typeOfEnemy == 1)
				{
					GameObject enemy = Instantiate(virusMalveillant, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
					delay = 0.0f;
					i++;
				}
			}
		}
	}

}
