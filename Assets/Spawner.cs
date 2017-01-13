using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public float m_FireIntervalMin = 5f;
    public float m_FireIntervalMax = 10;

    public Transform m_SpawnPosition;
    public GameObject m_SpawnStuff;

    public float m_LastShotTime;
    public float m_Timer;


    // Use this for initialization
    void Start()
    {
        m_LastShotTime = Time.time;
        m_Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer >= 10 && m_Timer < 20)
        {
            m_FireIntervalMin = 3;
            m_FireIntervalMax = 8;
        }
        if (m_Timer >= 20 && m_Timer < 30)
        {
            m_FireIntervalMin = 1;
            m_FireIntervalMax = 5;
        }
        if (m_Timer >= 30)
        {
            m_FireIntervalMin = 1;
            m_FireIntervalMax = 4;
        }
        bool canShoot = (m_LastShotTime + Random.Range(m_FireIntervalMin, m_FireIntervalMax)) < Time.time;
        //bool canShoot = (m_LastShotTime + 2f) < Time.time;
        // Shoot!
        if (canShoot)
        {
            if (m_SpawnStuff != null)
            {
                if (m_SpawnPosition != null)
                {

                    GameObject spawner = Instantiate(m_SpawnStuff, m_SpawnPosition.position, m_SpawnPosition.rotation) as GameObject;

                    //spawner.GetComponent<EnemySpeed>().velocity = 15;
                }
                //if (m_Timer >= 60)
                //{
                //    // game end
                //}
            }
            m_LastShotTime = Time.time;
        }

    }


}
