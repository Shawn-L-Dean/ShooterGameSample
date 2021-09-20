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

public class FaceObject : MonoBehaviour
{
    /**** Variables ****/
    public Transform ObjToFace = null;
    public bool FacePlayer = false;

    private void Awake()
    {
        if (!FacePlayer)
        {
            return;
        }
        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");
        if (PlayerObj != null)
        {
            ObjToFace = PlayerObj.transform;
        }


}//end Awake()


    // Update is called once per frame
    void Update()
    {
       if(ObjToFace = null)
        {
            return;
        }
        Vector3 DirToObj = ObjToFace.position - transform.position;

        if(DirToObj != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(DirToObj.normalized, Vector3.up);
        }
    }
}//end Update()
