using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    [SerializeField]
    private Canvas GameOverCanvas;

    private void Awake()
    {
        GameOverCanvas.transform.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameOverCanvas.transform.gameObject.SetActive(true);
        }
    }

}
