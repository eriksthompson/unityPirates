using UnityEngine;
namespace ThompsonErik.Lab1
{
    class FollowWithOffset : MonoBehaviour
    {
        [SerializeField] public Transform target;
        [SerializeField] private Vector3 offset;
        private void Update()
        {
            //Debug.Log(cs1.getCurrentCharacter());
            this.transform.SetPositionAndRotation(offset + target.transform.position, target.transform.rotation);
        }
    }
}
