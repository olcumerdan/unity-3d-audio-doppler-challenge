using UnityEngine;

public class FareKontrol : MonoBehaviour
{
    public float hassasiyet = 200f; // Farenin dönüş hızı
    float xDonus = 0f;
    float yDonus = 0f;

    void Start()
    {
        // Oyun başladığında fare imlecini ekrana kilitle ve gizle
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Farenin hareketlerini al
        float mouseX = Input.GetAxis("Mouse X") * hassasiyet * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * hassasiyet * Time.deltaTime;

        // Yukarı/aşağı bakma açısını hesapla ve sınırla (boyun kırılmasın diye -90 ile 90 arası)
        xDonus -= mouseY;
        xDonus = Mathf.Clamp(xDonus, -90f, 90f);

        // Sağa/sola bakma açısını hesapla
        yDonus += mouseX;

        // Kamerayı yeni açılara göre döndür
        transform.localRotation = Quaternion.Euler(xDonus, yDonus, 0f);
    }
}