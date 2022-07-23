using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveMain: MonoBehaviour
{
    [SerializeField] private Button MainMoveBtn;

    private void Awake()
    {
        MainMoveBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("02_Main");
        });
    }
}
