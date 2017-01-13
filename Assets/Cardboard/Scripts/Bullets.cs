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
	
	// Update is called once per frame
	void Update () {
        if (Lifetime > 0)
        {
            body.position += velocity * body.transform.forward * Time.fixedDeltaTime;
            Lifetime -= Time.fixedDeltaTime;
        }
        else
            alive = false;

        if(!alive)
        {
            Destroy(this.gameObject);
        }
	}
}
