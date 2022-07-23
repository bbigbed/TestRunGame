using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    float postionX = 14f;
    float upY = -1f;
    float downY = -2f;

    float timerUp = 0f;
    float timerDown = 0f;

    private void Update()
    {
        UpCoinPos();
        DownCoinPos();
    }

    public void UpCoinPos()
    {
        timerUp += Time.deltaTime;
        if (timerUp >= 1.75f)
        {
            Instantiate(coin, new Vector2(postionX, upY), Quaternion.identity);
            timerUp = 0f;
        }
    }

    public void DownCoinPos()
    {
        timerDown += Time.deltaTime;
        if (timerDown >= 0.5f)
        {
            Instantiate(coin, new Vector2(postionX, downY), Quaternion.identity);
            timerDown = 0f;
        }
    }

}
