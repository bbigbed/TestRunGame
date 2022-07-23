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
            // Score : 1이 나와야 하는데 그냥 1이 나오고 있다. - 1만 나오고 있음 - 해결 완료
            // -> 내 생각으로는 계속 돌아야 하지만 계속 돌고 있지 않음 1번만 돔
            // -> 내 생각으로는 코인 개별로 들어가기 때문에 코인이 하나밖에 없다함
            // -> 해결 됨
            // 이제 게임 종료할 차례임
            // 코인 스폰하는 것도 알아야 함 - 스폰 위치를 2개로 만들자 - 해결 완료
            // 플레이어가 점프가 한번밖에 안됨 - 해결 완료
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
