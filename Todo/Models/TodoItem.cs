using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo
{
	public class TodoItem
	{
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
        public bool Done { get; set; }
		
	}
}

