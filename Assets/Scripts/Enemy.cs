using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public virtual void AttackPlayer()
    {
        print("Enemy is attacking the player");
    }

    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
