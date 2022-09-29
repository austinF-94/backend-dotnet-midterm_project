using System.ComponentModel.DataAnnotations;

namespace midterm_project.Models;

public class Dragons {
    public int DragonId { get; set; }

    [Required]
    public string dragonName { get; set; }

    [Required]
    public string dragonImage { get; set; }

    [Required]
    public string dragonDescription { get; set; }

    [Required]
    public string dragonDetails { get; set; }    
}