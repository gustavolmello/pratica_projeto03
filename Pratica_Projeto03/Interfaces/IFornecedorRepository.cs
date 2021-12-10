﻿using Pratica_Projeto03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_Projeto03.Interfaces
{
    public interface IFornecedorRepository
    {
        //método abstrato (somente assinatura)
        void Exportar(Fornecedor fornecedor);
        void Importar(Guid idFornecedor);
    }
}
