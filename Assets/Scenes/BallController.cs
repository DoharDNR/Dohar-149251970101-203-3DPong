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

    void Start()
    {
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
