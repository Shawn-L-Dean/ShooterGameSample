/*
 * Created By: Shawn Dean
 * Date Created: September 20, 2021
 * 
 * Last Edited By: 
 * Last Updated: September 20, 2021
 * 
 * Description: Continuously moves gameObject
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    /**** Variables ****/
    public float MaxSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime; 
    }//end Update
}
