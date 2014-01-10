using UnityEngine;
using System.Collections;

public class fireShots : MonoBehaviour {

	public GameObject projectile;
	private float delay = 0.0f;


	void Start () {
		
	}

	void Update () {
	
		delay+= Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Enemy")
		{
			if(delay >= 1)
			{
				GameObject proj = Instantiate(projectile, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
				proj.GetComponent<projectile>().setTarget(other.gameObject);
				//Debug.LogWarning("FIRE !!!");
				delay = 0.0f;
			}
		}
	}
}
