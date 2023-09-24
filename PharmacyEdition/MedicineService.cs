using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyEdition
{
    public class MedicineService
    {
        private readonly List<Medicine> _medicine; 
        public MedicineService(List<Medicine> medicine)
        {
            _medicine = medicine;
        }

        public IQueryable<Medicine> GetAllAsync(Expression<Func<Medicine, bool>> predicate)
        {
            return _medicine.Where(predicate.Compile()).AsQueryable();
        }
        
        public ValueTask<ICollection<Medicine>> GetByIdAsync(IEnumerable<int> id)
        {
            var medicines = _medicine.Where(medicine => id.Contains(medicine.Id));
            return new ValueTask<ICollection<Medicine>>(medicines.ToList()); 
        }

        public void Update()
        {

        }

        public void  Create()
        {

        }

        public void Delete()
        {

        }

        public void Selling()
        {

        }
        
        public void Buying()
        {

        }
    }
}
