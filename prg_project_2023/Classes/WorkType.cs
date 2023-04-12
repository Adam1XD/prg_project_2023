using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prg_project_2023.Classes
{
    public class WorkType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public WorkType(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public WorkType(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Name, Description});
        }
    }
}
