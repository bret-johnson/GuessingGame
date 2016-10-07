using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGameRemastered.Models
{
    public class RemasteredModel
    {
        [Display(Name= "Enter your name:")]
        [Required(ErrorMessage ="You need to enter your name, bro.")]
        [MinLength(1, ErrorMessage = "Your name is too short, dude.")]
        [MaxLength(20, ErrorMessage ="Your name is way too long, fam")]
        public string PlayerName { get; set; }

        [Display(Name ="Guess is required")]
        [Required(ErrorMessage = "You forgot to guess. . .")]
        [Range(1,73, ErrorMessage = "Your guess must be between 1 and 73")]
        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess}";
        }

    }
}