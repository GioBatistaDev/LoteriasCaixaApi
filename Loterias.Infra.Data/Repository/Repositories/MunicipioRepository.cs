﻿using Loterias.Infra.Data.Model;
using Loterias.Infra.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loterias.Infra.Data.Repository.Repositories
{
    public class MunicipioRepository : BaseRepository<Municipio>, IMunicipioRepository
    {
        public MunicipioRepository(AppDbContext context) : base(context)
        {
        }
    }
}
