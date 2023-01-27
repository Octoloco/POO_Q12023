using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class ActorBrandonAntonio : MonoBehaviour

{
    public int Stamina;
    public int Damage;
    [SerializeField] public int[] Inventory = new int[8];
    protected float Speed = 4;
    public int Attack;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceStamina()
    {
        Stamina-=Damage;
    }

    
   public void RecieveDamage()
    {
        if (Attack >10)
        {
            Attack -= Damage;
        }
    }


    public void SpaceInventory()
    {
         
        
    }


   public void OnTriggerEnter()
    {
            
       Speed = Speed*2;
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Stamina--;
        }
    }


}
