using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.ViewModels
{
    public class AstuceListViewModel
    {
        public IEnumerable<Astuce> Astuces { get; set; }
    }
}
