using UnityEngine;

public class Destructable : MonoBehaviour {
    public Rigidbody ballRigidBody;
    public SphereCollider ballCollider;
    public Transform piecesParent;
    public Transform piecesPrefab;
    public GameObject wholeBall;

    public void Destruct()
    {
        //ballRigidBody = GetComponent<Rigidbody>();
        ballRigidBody.isKinematic = true;
        ballCollider.enabled = false;
        Transform clone = Instantiate(piecesPrefab, piecesParent.position, piecesParent.rotation);
        //clone.parent = piecesParent;
        Destroy(clone.gameObject, 10f);
        wholeBall.SetActive(false);
    }

    public void DeDestruct()
    {
        ballRigidBody.isKinematic = false;
        ballCollider.enabled = true;
        wholeBall.SetActive(true);
    }


}
