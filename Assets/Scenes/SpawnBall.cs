using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public BallController ballController;
    public int jumlahBola;
    public int durasiSpawn;
    public float durasi;

    public bool isSpawnBall1, isSpawnBall2, isSpawnBall3, isSpawnBall4;
    public Transform spawnBall1, spawnBall2, spawnBall3, spawnBall4;
    public GameObject ballObj;

    void Start()
    {
        RandomSpawn();
    }

    void Update()
    {
        if(jumlahBola > 0)
        {
            durasi -= 1 * Time.deltaTime;

            if (durasi < 0)
            {
                durasi = durasiSpawn;
                jumlahBola -= 1;
                RandomSpawn();

                if (isSpawnBall1)
                {
                    ballObj.GetComponent<BallController>().speed = new Vector3(8, 0, 4);
                    Instantiate(ballObj, spawnBall1);
                }

                if (isSpawnBall2)
                {
                    ballObj.GetComponent<BallController>().speed = new Vector3(-8, 0, 4);
                    Instantiate(ballObj, spawnBall2);
                }

                if (isSpawnBall3)
                {
                    ballObj.GetComponent<BallController>().speed = new Vector3(-4, 0, -8);
                    Instantiate(ballObj, spawnBall3);
                }

                if (isSpawnBall4)
                {
                    ballObj.GetComponent<BallController>().speed = new Vector3(8, 0, -4);
                    Instantiate(ballObj, spawnBall4);
                }
            }
        }
    }

    void RandomSpawn()
    {
        int angkaAcak;
        angkaAcak = Random.RandomRange(1, 4);

        if(angkaAcak == 1)
        {
            isSpawnBall1 = true;
            isSpawnBall2 = false;
            isSpawnBall3 = false;
            isSpawnBall4 = false;
        }else if(angkaAcak == 2)
        {
            isSpawnBall1 = false;
            isSpawnBall2 = true;
            isSpawnBall3 = false;
            isSpawnBall4 = false;
        }else if(angkaAcak == 3)
        {
            isSpawnBall1 = false;
            isSpawnBall2 = false;
            isSpawnBall3 = true;
            isSpawnBall4 = false;
        }
        else
        {
            isSpawnBall1 = false;
            isSpawnBall2 = false;
            isSpawnBall3 = false;
            isSpawnBall4 = true;
        }
    }
}
