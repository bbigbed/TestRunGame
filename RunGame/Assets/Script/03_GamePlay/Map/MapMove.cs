using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float mapSpeed = 10f;

    private void Update()
    {
        Debug.Log("움직이는 중");
        transform.Translate((-mapSpeed) * Time.deltaTime, 0, 0);

        if(transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
