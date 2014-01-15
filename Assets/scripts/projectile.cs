using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public float speed = 10.0f;
	public float range = 10.0f;

	private float dist;
	private float _damage;
	private GameObject target;

	public projectile(GameObject tar)
	{
		target = tar;
	}

	public void setTarget (GameObject tar)
	{
		target = tar;
	}

	public float damage
	{
		set{_damage = value;}
		get{ return _damage;}
	}
	public void setDamage (float damage)
	{
		this.damage = damage;
	}

	void Update ()
	{
		if (target != null) {
			transform.position = Vector2.Lerp (transform.position, target.transform.position, 0.1f);
		} 
		else {
			Destroy(this.transform.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		Debug.LogWarning(other.gameObject.tag);
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(this.transform.gameObject);
			target = null;
		}
	}
}