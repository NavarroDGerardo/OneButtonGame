using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScore : MonoBehaviour
{
    private UI_Manager _uiManager;

    // Use this for initialization
    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _uiManager.UpdateScore();
        }
    }
}
