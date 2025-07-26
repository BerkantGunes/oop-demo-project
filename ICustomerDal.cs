using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer> //İlgili interface classının özelliklerini getirir.
    {
        // job ile ilgili degerleri getiren imzayi attik
        List<Customer> GetCustomerListWithJob();
    }
}
