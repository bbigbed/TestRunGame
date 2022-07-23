using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMapMove : MonoBehaviour
{
    public float mapSpeed = 10f;
    public float startPos;
    public float endPos;

    private void Update()
    {
        transform.Translate(-1 * mapSpeed * Time.deltaTime, 0, 0);

        if(transform.position.x <= endPos)
        {
            MapEnd();
        }
    }

    private void MapEnd()
    {
        transform.Translate(-1 * (endPos - startPos), 0, 0);
    }

}
