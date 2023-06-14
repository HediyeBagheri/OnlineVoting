using System.ComponentModel.DataAnnotations;

public class AdviserDTO
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(128)]
    public string Name { get; set; }

    [Required, StringLength(128)]
    public string LastName { get; set; }
    public int CondidateId { get; set; }
}
