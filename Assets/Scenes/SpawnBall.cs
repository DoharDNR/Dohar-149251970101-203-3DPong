using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public BallController ballController;
    public int jumlahBola;
    public int durasiSpawn;
    public float durasi;

    public Transform spawnBall;
    public GameObject ballObj;
    public Vector3 readyToStart;

    void Update()
    {
        if(jumlahBola > 0)
        {
            durasi -= 1 * Time.deltaTime;
            ballObj.GetComponent<BallController>().speed = readyToStart;

            if (durasi < 0)
            {
                durasi = durasiSpawn;
                jumlahBola -= 1;
                Instantiate(ballObj, spawnBall);
            }
        }
    }
}
