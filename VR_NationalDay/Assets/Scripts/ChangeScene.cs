using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Plane"))
    print("work");
   // SceneManager.LoadScene("NEWRIYADH");
   }
}
