using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveGamePlay : MonoBehaviour
{
    [SerializeField] private Button GameStartBtn;

    private void Awake()
    {
        GameStartBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("03_GamePlay");
        });
    }
}
