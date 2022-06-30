using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;

    private Rigidbody rig;
    public Image iconSpeedUp;
    public int jumlahDurasi;
    public float durasi;

    public GameObject dinding1, dinding2, dinding3, dinding4;
    public Collider dindingCol1, dindingCol2, dindingCol3, dindingCol4;

    public GameObject scoreObj;
    public ScoreManager scoreManager;

    void OnCollisionEnter(Collision other)
    {
        if(other.collider == dindingCol1 )
        {
            scoreManager.AddPemain1Score(1);
        }else if(other.collider == dindingCol2)
        {
            scoreManager.AddPemain2Score(1);
        }else if( other.collider == dindingCol3)
        {
            scoreManager.AddPemain3Score(1);
        }
        else if(other.collider == dindingCol4)
        {
            scoreManager.AddPemain4Score(1);
        }
    }

    void Start()
    {
        dinding1 = GameObject.Find("Tembok1");
        dindingCol1 = dinding1.GetComponent<Collider>();
        dinding2 = GameObject.Find("Tembok2");
        dindingCol2 = dinding2.GetComponent<Collider>();
        dinding3 = GameObject.Find("Tembok3");
        dindingCol3 = dinding3.GetComponent<Collider>();
        dinding4 = GameObject.Find("Tembok4");
        dindingCol4 = dinding4.GetComponent<Collider>();

        scoreObj = GameObject.Find("AreaPertandingan3D");
        scoreManager = scoreObj.GetComponent<ScoreManager>();

        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        durasi = jumlahDurasi;
    }

    void Update()
    {

        //iconSpeedUp.fillAmount = 1*durasi;
        durasi -= 1*Time.deltaTime;
        if(durasi < 0)
        {
            durasi = 0;
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
