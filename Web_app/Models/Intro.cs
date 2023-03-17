
using System.ComponentModel.DataAnnotations;

namespace Web_app.Models;

public class Intro
{
    [Display(Name = "First Number")]
    public string FirstNumber { get; set; } = string.Empty;

    [Display(Name = "Second Number")]
    public string SecondNumber { get; set; } = string.Empty;
    
    public string Output { get; set; } = string.Empty;

}