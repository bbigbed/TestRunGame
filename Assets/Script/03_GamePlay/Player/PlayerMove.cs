using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    public Text SetTxt;

    [SerializeField]
    public Text txt;

    Rigidbody2D rigid;
    private float jumpPower = 8f;

    private bool isJump = false;
    private int isJumpCount = 0;

    public int Score;

    Vector3 PosX;

    private void Awake()
    {
         rigid = GetComponent<Rigidbody2D>(); 
    }

    private void Start()
    {
        Score = 0;
        txt = GameObject.Find("Score::ScoreText").GetComponent<Text>();
        Debug.Log(txt.name);
    }

    private void Update()
    {
        Jump();
        PosClickX();
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isJump != true)
            {
                isJump = true;
                rigid.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
            }
            //isJump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Coin") == 0)
        {
            Destroy(collision.gameObject);
            // Score : 1�� ���;� �ϴµ� �׳� 1�� ������ �ִ�. - 1�� ������ ���� - �ذ� �Ϸ�
            // -> �� �������δ� ��� ���ƾ� ������ ��� ���� ���� ���� 1���� ��
            // -> �� �������δ� ���� ������ ���� ������ ������ �ϳ��ۿ� ������
            // -> �ذ� ��
            // ���� ���� ������ ������
            // ���� �����ϴ� �͵� �˾ƾ� �� - ���� ��ġ�� 2���� ������ - �ذ� �Ϸ�
            // �÷��̾ ������ �ѹ��ۿ� �ȵ� - �ذ� �Ϸ�
            Score += 1;
            txt.text = Score.ToString();
            SetTxt.text = Score.ToString();
        }
    }

    public void PosClickX()
    {
        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.y < -500)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;
    }

}
