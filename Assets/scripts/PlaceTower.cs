using UnityEngine;
using System.Collections;

public class PlaceTower : MonoBehaviour {

	public GameObject tower;

	// Use this for initialization
	void Start () {
		renderer.material.color = new Color (0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Debug.LogWarning("CLIQUE !!!");
		GameObject t = Instantiate(tower, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
	}

	void OnMouseOver() {
		//renderer.material.color += new Color(0.1F, 0, 0) * Time.deltaTime;
		renderer.material.color = new Color (255, 255, 255, 0.2F);
	}

	void OnMouseExit() {
		renderer.material.color = new Color (0, 0, 0, 0);
	}
}
