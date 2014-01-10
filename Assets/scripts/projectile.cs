using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public float speed = 10.0f;
	public float range = 10.0f;

	private float dist;
	private GameObject target;

	public projectile(GameObject tar)
	{
		target = tar;
	}

	public void setTarget (GameObject tar)
	{
		target = tar;
	}

	void Update ()
	{
		transform.position = Vector2.Lerp(transform.position, target.transform.position, 0.1f);
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.LogWarning(other.gameObject.tag);
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(this.transform.gameObject);
		}
	}
}