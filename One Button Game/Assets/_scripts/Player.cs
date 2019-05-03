using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private int state = 1;
    public Animator anim;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim = GetComponent<Animator>();
        anim.SetInteger("state", state);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            state += 1;
        }
        if(state == 6)
        {
            state = 2;
        }

        if (transform.position.x >= 3.4f)
        {
            transform.position = new Vector3(3.3f, transform.position.y, 0);
            state = 5;
        }
        if(transform.position.x <= -3.4f)
        {
            transform.position = new Vector3(-3.3f, transform.position.y, 0);
            state = 3;
        }

        anim.SetInteger("state", state);

        if(state == 2)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(state == 4)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gameManager.RestartGame();
        Destroy(this.gameObject);
    }
}
