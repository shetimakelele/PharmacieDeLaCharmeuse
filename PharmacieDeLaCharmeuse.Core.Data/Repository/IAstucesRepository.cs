using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public interface IAstuceRepository
    {
        IEnumerable<Astuce> GetAllAstuces();

       Astuce GetAstuceById(int id);
    }
}
