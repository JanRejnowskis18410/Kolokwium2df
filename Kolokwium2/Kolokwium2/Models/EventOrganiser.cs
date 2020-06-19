using System;
using System.Collections.Generic;

namespace Kolokwium2.Models
{
    public partial class EventOrganiser
    {
        public int IdOrganiser { get; set; }
        public int IdEvent { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual Organiser IdOrganiserNavigation { get; set; }
    }
}
