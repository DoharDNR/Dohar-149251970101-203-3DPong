using UnityEngine;

public class PaddleControllerLR : MonoBehaviour
{
    public int speed;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public bool isActive;
    public int jumlahDurasi;
    public float durasi;

    void Update()
    {
        MoveObject(GetInput());
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

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed *Time.deltaTime;
            if(transform.position.x > 4)
            {
                ;
            }

        } else if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed *Time.deltaTime;
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        transform.Translate(movement.x, movement.y, movement.z);
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
