using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleControllerLR paddlePlayer, paddlePlayer2;
    public int magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddlePlayer.ActivatedPUSpeedPaddle(magnitude);
            paddlePlayer2.ActivatedPUSpeedPaddle(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
