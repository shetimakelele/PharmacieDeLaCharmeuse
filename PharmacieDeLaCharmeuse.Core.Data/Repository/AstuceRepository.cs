using Microsoft.EntityFrameworkCore;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public class AstuceRepository : IAstuceRepository
    {
        private readonly DefaultContext _context;

        #region Constructeurs
        public AstuceRepository(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
        public IEnumerable<Astuce> GetAllAstuces()
        {
            return _context.Astuces;
        }

        public Astuce GetAstuceById(int id)
        {
            return _context.Astuces.FirstOrDefault(a => a.AstuceId == id);
        }
    }
}
