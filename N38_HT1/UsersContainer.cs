using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UsersContainer modelini yarating

//unda quyidagi memberlar bo'lsin
//- consturctor - default constructor bo'lsin
//- constructor - userlar kolleksiyasini qabul qiladigan bo'lsin ( array, list yoki IEnumerable bo'lsa ham )
//-indexer  - id bo'yicha bitta value qaytaradigan
//- indexer - keyword bo'ycha bitta value qaytaradigan
//- indexer - index bo'yicha bitta value qaytaradigan ( array ga o'xshab )
//-unda IEnumerable interfeysini implement qiling
//- va userlarni saqlash uchun biror kolleksiya

//- UsersContainer dan bitta instance oling
//- LINQ methodlarini foydalanib query qiling
//- indexer lar dan foydalanib ekranga bir nechta user larni chiqaring


namespace N38_HT1
{
    public class UsersContainer : IEnumerable<User>
    {
        private IEnumerable<User> _users;
        public UsersContainer()
        {
            _users = new List<User>();
        }
        public UsersContainer(IEnumerable<User> users)
        {
            _users = users;
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }

        public User this[Guid id]
        {
            get 
            {
                return _users.FirstOrDefault(x => x.Id == id);
            }
        }

        public User this[string keyWord] 
            => _users.First(user => user.EmailAddress.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                                || user.LastName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                                    || user.EmailAddress.Contains(keyWord, StringComparison.OrdinalIgnoreCase));
        
        public User this[int index] => _users.ToArray()[index];
    }
}
