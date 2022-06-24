using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddlePlayer, paddlePlayer2;
    public int countLong;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddlePlayer.ActivatePULongPaddle(countLong);
            paddlePlayer2.ActivatePULongPaddle(countLong);
            manager.RemovePowerUp(gameObject);
        }
    }
}
