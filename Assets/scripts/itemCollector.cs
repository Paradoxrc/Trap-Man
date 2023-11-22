using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemCollector : MonoBehaviour
{
    public int cherries = 0;
    private int oranges = 0;
    [SerializeField] private Text cherriesText;
   
    [SerializeField] private AudioSource collectiongItems;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Fruits: (" + cherries + "/10)";
            collectiongItems.Play();
        }
       
    }
}
