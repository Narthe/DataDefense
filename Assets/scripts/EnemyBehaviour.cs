using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	private enum EnemyType{
		aaa,
		bbb,
		ccc
	}

	public float speed = 2.0f;
	
	private float dist;
	private float life = 3.0f;
	private bool carryingData = false;
	private EnemyType type;

	void Start () {
		switch (type) {
		case EnemyType.aaa:
		{
			life = 3;
			break;
		}
		case EnemyType.bbb:
		{
			life = 5;
			break;
		}
		case EnemyType.ccc:
		{
			life = 10;
			break;
		}
		}
	}
	
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * speed);
		dist += Time.deltaTime * speed;

		if (life <= 0)
		{
			Destroy(this.transform.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if(other.gameObject.tag == "Projectile")
		{
			life -= other.transform.gameObject.GetComponent<projectile>().damage;
		}
	}
}
