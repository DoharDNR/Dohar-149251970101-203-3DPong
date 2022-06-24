using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;
    public Image iconSpeedUp;
    public int jumlahDurasi;
    public float durasi;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //rig.velocity = speed;
        durasi = jumlahDurasi;
    }

    void Update()
    {
        iconSpeedUp.fillAmount = 1*durasi;
        durasi -= 1*Time.deltaTime;
        if(durasi < 0)
        {
            durasi = 0;
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 0);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
