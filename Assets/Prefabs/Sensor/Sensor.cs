using UnityEngine;

public class Sensor : MonoBehaviour
{
    public Transform target;
    public float maxAngle;
    public float maxRadius;

    private bool targetAquired;

    private void OnDrawGizmos()
    {
        // yellow sphere around sensor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, maxRadius);

        // blue field of view bounderies
        Vector3 line1 = Quaternion.AngleAxis(maxAngle, transform.up) * transform.forward * maxRadius;
        Vector3 line2 = Quaternion.AngleAxis(-maxAngle, transform.up) * transform.forward * maxRadius;
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, line1);
        Gizmos.DrawRay(transform.position, line2);

        if (!targetAquired)
            Gizmos.color = Color.red;
        else
            Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, (target.position - transform.position).normalized * maxRadius);

        // black line to indicate sensor front
        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, transform.forward * maxRadius);
    }

//    public static bool targetInFieldOfView()
//    {
//        return false;
//    }
//
//    private void Update()
//    {
//        targetAquired = targetInFieldOfView();
//    }
}
