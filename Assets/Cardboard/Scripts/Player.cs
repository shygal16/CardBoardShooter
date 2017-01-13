using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public int Health = 3;
    public bool Alive = true;
    public Collider PlayerCollider;
    public Texture2D HealthIcon;
    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
       
	}
	/*
    void OnGui()
    {
        for (int i = 0; i < Health; ++i)
        {
            GUI.DrawTexture(new Rect(i * 64 + 10, 10, 64, 64), HealthIcon);
        }
    }
    */
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {
            --Health;
            Destroy(other.gameObject);
            if(Health<=0)
            {
                Alive = false;
            }
        }
    }
}
