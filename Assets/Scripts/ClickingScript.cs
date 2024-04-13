using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerScript : MonoBehaviour
{
    public TextMeshProUGUI pointsText; // Przypisz UI Text, który będzie wyświetlał punkty
    public LayerMask clickableLayer; // Warstwa obiektów klikalnych
    private int points = 0; // Liczba punktów
    public int clickPower = 1;

    void Update()
    {
        // Sprawdź, czy użytkownik kliknął myszą (dla PC) lub dotknął ekranu (dla urządzeń mobilnych)
        if (Input.GetMouseButtonDown(0))
        {
            // Pobierz pozycję kliknięcia na ekranie
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            // Sprawdź, czy kliknięcie trafia w obiekt z koliderem na odpowiedniej warstwie
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero, Mathf.Infinity, clickableLayer);
            
            // Jeśli trafiono w obiekt z koliderem, zwiększ punkty
            if (hit.collider != null)
            {
                points = points + clickPower;
                // Zaktualizuj wyświetlaną liczbę punktów
                UpdatePointsText();
            }
        }
    }

    void UpdatePointsText()
    {
        // Aktualizuj tekst UI, aby pokazywał aktualną liczbę punktów
        pointsText.text = "Coins: " + points.ToString();
    }
}

