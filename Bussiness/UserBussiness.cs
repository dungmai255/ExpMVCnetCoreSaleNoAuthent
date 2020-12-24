using ExpMVCnetCoreSaleNoAuthent.DAL;
using ExpMVCnetCoreSaleNoAuthent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Business
{
    public class UserBussiness
    {
        private ProductsContext _productContext;
        public UserBussiness(ProductsContext productContext)
        {
            _productContext = productContext;
        }

        public UserModel GetUser(int id)
        {
            var user = new UserModel();
            user = _productContext.User.Where(s => s.id == id).FirstOrDefault();
            return user;
        }

        public UserModel GetUser(string name)
        {
            var user = new UserModel();
            user = _productContext.User.Where(s => s.name == name).FirstOrDefault();
            return user;
        }
        public ICollection<UserModel> GetAllUser()
        {
            var user = new List<UserModel>();
            user = _productContext.User.ToList();
            return user;
        }
    }
}
