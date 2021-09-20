/*
 * Created By: Shawn Dean
 * Date Created: September 20, 2021
 * 
 * Last Edited By: 
 * Last Updated: September 20, 2021
 * 
 * Description: Continuously rotates gameObject
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    /****Variables****/
    public float DamageRate = 10f; //Damage per second

    private void OnTriggerStay(Collider other)
    {
        Health h = other.gameObject.GetComponent<Health>();
        if(h == null)
        {
            return;
        }
        h.HealthPoints -= DamageRate * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
