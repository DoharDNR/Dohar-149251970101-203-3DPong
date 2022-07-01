using UnityEngine;

public class PaddleControllerLR : MonoBehaviour
{
    public int speed;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public bool isActive;
    public int jumlahDurasi;
    public float durasi;

    float cameraPitch;

    void Update()
    {
        MoveObject();
        if (isActive)
        {
            durasi -= 1 * Time.deltaTime;
        }
        if (durasi < 0)
        {
            durasi = 0;
            isActive = false;
            transform.localScale = new Vector3(1, 3);
            speed = 5;
        }
    }

    void MoveObject()
    {
        if (Input.GetKey(leftKey))
        {
            float moveLeft = speed * Time.deltaTime;
            float rawPos = transform.position.x - moveLeft;
            float clampPos = Mathf.Clamp(rawPos, -4, 4);
            transform.position = new Vector3(clampPos, transform.position.y, transform.position.z);
        } else if (Input.GetKey(rightKey))
        {
            float moveLeft = speed * Time.deltaTime;
            float rawPos = transform.position.x + moveLeft;
            float clampPos = Mathf.Clamp(rawPos, -4, 4);
            transform.position = new Vector3(clampPos, transform.position.y, transform.position.z);
        }
    }

    public void ActivatePULongPaddle(float countLong)
    {
        isActive = true;
        durasi = jumlahDurasi;
        if (isActive)
        {
            transform.localScale = new Vector3(1, 3 * countLong);
        }
    }

    public void ActivatedPUSpeedPaddle(int magnitude)
    {
        isActive = true;
        durasi = jumlahDurasi;
        if (isActive)
        {
            speed *= magnitude;
            Debug.Log("Sudah Aktif");
        }
    }
}
