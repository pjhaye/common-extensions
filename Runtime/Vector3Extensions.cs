using UnityEngine;

namespace CommonExtensions
{
    public static class Vector3Extensions
    {
        public static Vector3 RotateAround(this Vector3 thisVector3, Vector3 otherVector3, Quaternion rotation)
        {
            var distance = Vector3.Distance(thisVector3, otherVector3);
            var toThisVector = (thisVector3 - otherVector3).normalized;
            var rotatedToOtherVector = rotation * toThisVector;
            return otherVector3 + rotatedToOtherVector * distance;
        }
    }
}