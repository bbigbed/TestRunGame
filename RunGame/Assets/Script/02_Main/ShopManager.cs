using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private Canvas ShopPop;

    [SerializeField]
    private Button ShopOpenBtn;
    [SerializeField]
    private Button ShopCloseBtn;

    private void Awake()
    {
        ShopPop.gameObject.SetActive(false);
    }

    private void Start()
    {
        ShopOpenBtn.onClick.AddListener(() =>
        {
            ShopPop.gameObject.SetActive(true);
        });

        ShopCloseBtn.onClick.AddListener(() =>
        {
            ShopPop.gameObject.SetActive(false);
        });
    }
}
