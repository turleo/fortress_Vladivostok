using UnityEngine;

namespace Interaction.Interactable.Cannon
{
    public class Cannon : Interactable
    {
        public GameObject cannonBallPrefab; 
        public Transform firePoint; 
        public Vector3 initialVelocity; 
        public override void Interact()
        {
            GameObject cannonBall = Instantiate(
                cannonBallPrefab,
                firePoint.position,
                Quaternion.identity);
            Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
            rb.AddForce(initialVelocity);
        }
        public override string Hint()
        {
            return "выстрелить";
        }
    }
}