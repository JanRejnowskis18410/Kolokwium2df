using System;
using System.Collections.Generic;

namespace Kolokwium2.Models
{
    public partial class ArtistEvent
    {
        public int IdArtist { get; set; }
        public int IdEvent { get; set; }
        public DateTime PerformanceDate { get; set; }

        public virtual Artist IdArtistNavigation { get; set; }
        public virtual Event IdEventNavigation { get; set; }
    }
}
