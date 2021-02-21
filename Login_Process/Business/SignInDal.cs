
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Login_Process.Business
{
    public class SignInDal
    {
        //public void Add(SignIn login)
        //{
        //    using (SignInContext context =new SignInContext())
        //    {
        //        var entity = context.Entry(login);
        //        entity.State = EntityState.Added;
        //        context.SaveChanges();

        //    }
        //}

        public SignIn GetSign(Expression<Func<SignIn, bool>> filter)
        {
            using (UygulamaContext context = new UygulamaContext())
            {
                return context.Set<SignIn>().SingleOrDefault(filter);
            }
        }
        public List<SignIn> GetAll(Expression<Func<SignIn, bool>> filter = null)
        {
            using (UygulamaContext context = new UygulamaContext())
            {
                return context.Set<SignIn>().ToList();
            }
        }
    }
}
