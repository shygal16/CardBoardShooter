using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	public float m_minDis = 1.0f;
	public float m_speed =2.0f;
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (target);

		if (Vector3.Distance (transform.position, target.transform.position) >= m_minDis) 
		{
			transform.position += transform.forward * m_speed * Time.deltaTime;
		}
			
	}
		
}
