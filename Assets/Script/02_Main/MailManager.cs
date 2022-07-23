using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailManager : MonoBehaviour
{
    [SerializeField]
    private Canvas MailPop;

    [SerializeField]
    private Button MailOpenBtn;
    [SerializeField]
    private Button MailCloseBtn;

    private void Awake()
    {
        MailPop.gameObject.SetActive(false);
    }

    private void Start()
    {
        MailOpenBtn.onClick.AddListener(() =>
        {
            MailPop.gameObject.SetActive(true);
        });

        MailCloseBtn.onClick.AddListener(() =>
        {
            MailPop.gameObject.SetActive(false);
        });
    }
}
