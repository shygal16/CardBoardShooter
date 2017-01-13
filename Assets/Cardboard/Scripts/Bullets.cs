using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {
    public float Lifetime = 5;
    public float velocity = 5;
    public bool alive = true;
    public Rigidbody body;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collider collider)
	{
		if (collider.tag == "Enemy") 
		{
			alive = false;
			Destroy (collider.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if (alive) 
		{
			if (Lifetime > 0) 
			{
				body.position += velocity * body.transform.forward * Time.fixedDeltaTime;
				Lifetime -= Time.fixedDeltaTime;
			} 
			else
			{
				alive = false;
			}
		}
		else 
		{
			Destroy (this.gameObject);
		}
	}
}
