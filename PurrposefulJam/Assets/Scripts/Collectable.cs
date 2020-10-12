using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static Collectable instance;

    public int collectable = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            collectable++;
            UIController.instance.UpdateCollectableText();
            Debug.Log("Player Collected Item");
            Destroy(gameObject);
        }
    }
}
