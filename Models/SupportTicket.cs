using System.ComponentModel.DataAnnotations;

namespace ExamenParcialAPI.Models;

public class SupportTicket
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Subject { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string RequesterEmail { get; set; } = null!;

    public string? Description { get; set; }

    [Required]
    public string Severity { get; set; } = null!;

    [Required]
    public string Status { get; set; } = null!;

    [Required]
    public DateTime OpenedAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public string? AssignedTo { get; set; }
}