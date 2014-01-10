using UnityEngine;
using System.Collections;

public class EnemyBehaviourScript : MonoBehaviour {

	public float speed = 2.0f;
	
	private float dist;
	private float life = 3.0f;

	void Start () {
	}
	
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * speed);
		dist += Time.deltaTime * speed;
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if(other.gameObject.tag == "Projectile")
		{
			life--;
		}
	}
}
