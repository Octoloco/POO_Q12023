using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySergioAboites : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
