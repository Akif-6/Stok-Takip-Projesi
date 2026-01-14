using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace stok_takip.DAL
{
    
    public interface IRepository<T>
    {
        List<T> Listele();
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(int id);
    }
}
