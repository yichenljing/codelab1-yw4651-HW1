using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red; //change prize color to red when collision

            transform.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));
        }
       
    }
}
