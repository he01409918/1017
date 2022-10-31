using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public GameObject effect;
    public GameObject sfx;
    public int score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            GameObject fx = Instantiate(effect , this.transform.position , this.transform.rotation);
            Destroy(fx, 5);
            GameObject _sfx = Instantiate(sfx, this.transform.position, this.transform.rotation);
            Destroy(_sfx, 5);
            Manager.Instance.OnAddScore(score);
            Destroy(gameObject);
        }
    }
}
