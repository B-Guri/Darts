using UnityEngine;
using TMPro;

public class DartController : MonoBehaviour
{
    [SerializeField] private TextMeshPro text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (other.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        try
        {
            float count = float.Parse(other.name);
            text.text = (float.Parse(text.text) + count).ToString();
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        catch
        {
            ;
        }
    }
}
