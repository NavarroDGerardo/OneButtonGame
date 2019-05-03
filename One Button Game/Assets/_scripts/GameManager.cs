using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool GameOver = true;
    private UI_Manager uiManager;
    private spawnManager sManager;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        sManager = GameObject.Find("Spawn_manager").GetComponent<spawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true)
        {
            uiManager.showTittleScreen();
            sManager.startGame();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameOver = false;
                uiManager.hideTittleScreen();
                Instantiate(player, new Vector3(0, 3, 0), Quaternion.identity);
                sManager.startGame();
            }
        }
    }

    public void RestartGame()
    {
        StartCoroutine(resetGame());
    }

    public IEnumerator resetGame()
    {
        yield return new WaitForSeconds(3.0f);
        GameOver = true;
    }
}
