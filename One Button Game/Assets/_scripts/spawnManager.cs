using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    [SerializeField] private GameObject tombStoneObstacle;
    [SerializeField] private GameObject phantomPrefab;
    [SerializeField] private GameObject coinPrefab;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void startGame()
    {
        StartCoroutine(tombCreation());
        //StartCoroutine(phnatomCreation());
        StartCoroutine(coinCreation());
    }

    public void stopGame()
    {
        StopCoroutine(tombCreation());
        //StopCoroutine(phnatomCreation());
        StopCoroutine(coinCreation());
    }

    public IEnumerator tombCreation()
    {
        while (_gameManager.GameOver == false)
        {
            Instantiate(tombStoneObstacle, new Vector3(Random.Range(-3.35f, 3.9f), -6, 0), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }

    /*public IEnumerator phnatomCreation()
    {
        while (_gameManager.GameOver == false)
        {
            Instantiate(phantomPrefab, new Vector3(Random.Range(-3.1f, 3.1f), -6, 0), Quaternion.identity);
            yield return new WaitForSeconds(8.0f);
        }
    }*/

    public IEnumerator coinCreation()
    {
        while (_gameManager.GameOver == false)
        {
            Instantiate(coinPrefab, new Vector3(Random.Range(-3.4f, 3.4f), -6, 0), Quaternion.identity);
            yield return new WaitForSeconds(8.0f);
        }
    }
}
