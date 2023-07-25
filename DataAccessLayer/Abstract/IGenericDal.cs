using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        // T değeri al(entity). T class olmalı classa ait olanları üstüne alabilmeli
        void Insert(T t);
        //T tipinde türeyen t parametresi
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
