using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetManager : MonoBehaviour
{
    [SerializeField]
    private Canvas SetPop;

    [SerializeField]
    private Button SetPopOpen;
    [SerializeField]
    private Button SetPopClose;

    [SerializeField]
    private Button SetPopReset;

    private void Awake()
    {
        SetPop.gameObject.SetActive(false);
    }

    private void Start()
    {
        SetPopOpen.onClick.AddListener(() =>
        {
            SetPop.gameObject.SetActive(true);
        });

        SetPopClose.onClick.AddListener(() =>
        {
            SetPop.gameObject.SetActive(false);
        });

        SetPopReset.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("01_Logo");
        });
    }

}
