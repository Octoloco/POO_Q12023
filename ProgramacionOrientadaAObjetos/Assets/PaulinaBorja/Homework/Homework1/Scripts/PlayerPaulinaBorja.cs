using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaulinaBorja : ActorPaulinaBorja
{
    public int food;
    public int bombs;
    public int craftMaterials;
    public bool power;
    public bool ableToCraft;

    // Start is called before the first frame update
    void Start()
    {
        food = 0;
        craftMaterials = 0;
        ableToCraft = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void feed()
    {
        
    }

    public void craft() 
    { 
        if(craftMaterials > 3) 
        { 
            ableToCraft = true;
            if (ableToCraft == true)
            {
                useCraftMaterials();
            }
        }
    }

    public void releasepower()
    {
        if(power==true) { }
    }

    public void useBombs()
    {

    }

    public void useCraftMaterials() 
    { 
    
    }
}
