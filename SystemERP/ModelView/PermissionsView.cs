using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemERP.View.ModelView
{
    public class PermissionsView : INotifyPropertyChanged
    {
        [DisplayName("Descripcion")]
        public string Description { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
