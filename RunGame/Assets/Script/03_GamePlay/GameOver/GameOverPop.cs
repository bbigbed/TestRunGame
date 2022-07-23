using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPop : MonoBehaviour
{
    [SerializeField]
    private Button ReStart;
    [SerializeField]
    private Button Stop;

    private void Awake()
    {
        ReStart.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("03_GamePlay");
        });

        Stop.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("02_Main");
        });
    }

}
