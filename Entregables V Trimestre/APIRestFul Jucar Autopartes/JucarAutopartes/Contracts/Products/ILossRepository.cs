using Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Products
{
    public interface ILossRepository
    {
        /* Crear */
        void CreateLossForAutopart(Guid autopartId, Loss loss);

        /* Listar */
        Task<IEnumerable<Loss>> GetLossesAsync(Guid autopartId, bool trackChanges);

        /* Único Registro */
        Task<Loss> GetLossByAutopartAsync(Guid autopartId, Guid id, bool trackChanges);

        /* Eliminar*/
        void DeleteLoss(Loss loss);
    }
}
