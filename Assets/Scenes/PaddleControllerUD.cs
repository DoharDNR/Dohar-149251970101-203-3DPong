using UnityEngine;

public class PaddleControllerUD : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    public bool isActive;
    public int jumlahDurasi;
    public float durasi;

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

    private void MoveObject()
    {
        if (Input.GetKey(upKey))
        {
            float moveLeft = speed * Time.deltaTime;
            float rawPos = transform.position.z + moveLeft;
            float clampPos = Mathf.Clamp(rawPos, -4, 4);
            transform.position = new Vector3(transform.position.x, transform.position.y, clampPos);
        } else if (Input.GetKey(downKey))
        {
            float moveLeft = speed * Time.deltaTime;
            float rawPos = transform.position.z - moveLeft;
            float clampPos = Mathf.Clamp(rawPos, -4, 4);
            transform.position = new Vector3(transform.position.x, transform.position.y , clampPos);
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
