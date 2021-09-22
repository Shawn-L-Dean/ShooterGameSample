/*
 * Created By: Shawn Dean
 * Date Created: September 22, 2021
 * 
 * Last Edited By: 
 * Last Updated: September 22, 2021
 * 
 * Description: Ammo mechanics
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    /**** Variables ****/
    public float Damage = 100f;
    public float LifeTime = 2f;

    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", LifeTime);
    }//End OnEnable

    private void OnTriggerEnter(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        H.HealthPoints -= Damage;
        Die();
    }//End OnTriggerEnter

    void Die()
    {
        gameObject.SetActive(false);
    }//End die


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
