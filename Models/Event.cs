using System.ComponentModel.DataAnnotations;

namespace ExamenParcialAPI.Models;

public class Event
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    public string Location { get; set; } = null!;
    public DateTime StartAt { get; set; }
    public DateTime? EndAt { get; set; }         // nullable
    public bool IsOnline { get; set; }
    public string? Notes { get; set; }           // nullable
}