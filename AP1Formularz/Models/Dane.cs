using System.ComponentModel.DataAnnotations;

namespace AP1Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć minimum 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć minimum 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać email")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            ErrorMessage = "Hasło musi mieć min. 8 znaków, zawierać małą literę, dużą literę oraz cyfrę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "Numer telefonu może zawierać tylko cyfry i opcjonalnie '+' na początku")]
        public string Telefon { get; set; }


        [Required(ErrorMessage = "Proszę podać wiek")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Wiek musi być liczbą całkowitą")]
        [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale 10–80 lat")]
        public string Wiek { get; set; }

        [Required(ErrorMessage = "Wybierz miasto")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Warszawa = 1,
            Krakow = 2,
            Gdansk = 3,
            Poznan = 4,
            Wroclaw = 5
        }
    }
}
