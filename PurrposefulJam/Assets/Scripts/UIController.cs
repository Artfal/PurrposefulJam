using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Text collectableText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        collectableText.text = Collectable.instance.collectable.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCollectableText()
    {
        collectableText.text = Collectable.instance.collectable.ToString();
    }
}
