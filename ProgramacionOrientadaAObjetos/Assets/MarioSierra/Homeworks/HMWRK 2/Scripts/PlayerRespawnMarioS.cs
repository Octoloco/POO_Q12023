using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawnMarioS : MonoBehaviour
{
    public GameObject[] hearts;
    public GameObject player;
    private int life;
    public Transform respawn;
    // Start is called before the first frame update
    void Start()
    {
        life = hearts.Length;
    }

   private void CheckLife()
    {
        if (life<1)
        {
            Destroy(hearts[0].gameObject);
            Destroy(player);

        }

       else if (life < 2)
       {
            Destroy(hearts[1].gameObject);
            Destroy(player);

        }

        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            Destroy(player);
        }
   }
    public void PlayerDamaged()
    {
       
        Instantiate(player,respawn.position, Quaternion.identity);
        life--;
        CheckLife();
    }
}


