using System;
using System.ComponentModel.DataAnnotations;

namespace giorgetti.alessio._5h.SecondaWeb.Models
{
    public class Prenotazione
    {
        public string Nome { get; set; }
        public int PrenotazioneId { get; set; }

        [Required(ErrorMessage="Inserisci una Email valida")]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DataPrenotazione { get; set; }=DateTime.Now;


        
    }
}