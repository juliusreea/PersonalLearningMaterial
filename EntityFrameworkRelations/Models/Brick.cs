using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkRelations.Models;

public enum Color
{
    Black,
    Red,
    Green,
    Blue,
    Yellow,
    White
}

public class Brick
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string Title { get; set; } = string.Empty;
    public Color Color { get; set; }
    public List<Tag> Tags { get; set; }
    public List<BrickAvailability> BrickAvailability { get; set; }

}
