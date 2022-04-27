
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityFrameworkRelations.Models;

public class Tag
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string Title { get; set; } = string.Empty;
    public List<Brick> Bricks { get; set; } = new ();
}
