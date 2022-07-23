using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMove : Coin
{

    private float CoinSpeed = 12f;


    private void Update()
    {
        transform.Translate((-CoinSpeed) * Time.deltaTime, 0, 0);

        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.x < -4000)
        {
            Destroy(gameObject);
        }
    }
}
