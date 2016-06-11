using UnityEngine;

public class TapToPlaceParent : MonoBehaviour
{
    bool placing = false;
    void Start()
    {
        SpatialMapping.Instance.DrawVisualMeshes = true;
    }

    public GameObject m_gameObj;

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo,
            30.0f, SpatialMapping.PhysicsRaycastMask))
        {
           // var pt = hitInfo.point;
           // GameObject go = Instantiate(m_gameObj, pt, m_gameObj.transform.rotation) as GameObject;
            //GameObject coll = GameObject.Find("Origami Collection");
            //coll.
            //go.layer = 5;
            //Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position, transform.rotation);
            //var gameObj = UnityEngine.Inst
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If the user is in placing mode,
        // update the placement to match the user's gaze.

        //if (placing)
        //{
        //    // Do a raycast into the world that will only hit the Spatial Mapping mesh.
        //    var headPosition = Camera.main.transform.position;
        //    var gazeDirection = Camera.main.transform.forward;

        //    RaycastHit hitInfo;
        //    if (Physics.Raycast(headPosition, gazeDirection, out hitInfo,
        //        30.0f, SpatialMapping.PhysicsRaycastMask))
        //    {
        //        // Move this object's parent object to
        //        // where the raycast hit the Spatial Mapping mesh.
        //        this.transform.parent.position = hitInfo.point;

        //        // Rotate this object's parent object to face the user.
        //        Quaternion toQuat = Camera.main.transform.localRotation;
        //        toQuat.x = 0;
        //        toQuat.z = 0;
        //        this.transform.parent.rotation = toQuat;
        //    }
        //}
    }
}
