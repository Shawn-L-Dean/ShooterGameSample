
/*
 * Created By: Shawn Dean
 * Date Created: September 15, 2021
 * 
 * Last Edited By: 
 * Last Updated: September 15, 2021
 * 
 * Description: Bounds player nmovement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    public Rect levelBounds; // The x,y and w,h or the bounding rectangle

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, levelBounds.xMin, levelBounds.xMax),
            transform.position.y, Mathf.Clamp(transform.position.z, levelBounds.yMin, levelBounds.yMax));
    }

    private void OnDrawGizmosSelected()
    {
        const int cubeDepth = 1;
        Vector3 boundsCenter = new Vector3(levelBounds.xMin + levelBounds.width * 0.5f, 0, levelBounds.yMin + levelBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(levelBounds.width, cubeDepth, levelBounds.height);

        Gizmos.DrawWireCube(boundsCenter, boundsHeight);
    }
}
