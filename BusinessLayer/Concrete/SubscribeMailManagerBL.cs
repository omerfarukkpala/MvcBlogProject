using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManagerBL : ISubscribeMailServiceBL
    {
        ISubscribeMailDAL _subscribeMailDal;

        public SubscribeMailManagerBL(ISubscribeMailDAL subscribeMailDal)
        {
            _subscribeMailDal = subscribeMailDal;
        }

        public SubscribeMail GetByID(int id)
        {
            return _subscribeMailDal.GetByID(id);
        }

        public List<SubscribeMail> GetList()
        {
            return _subscribeMailDal.List();
        }

        public void TAdd(SubscribeMail t)
        {
            _subscribeMailDal.Insert(t);
        }

        public void TDelete(SubscribeMail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubscribeMail t)
        {
            throw new NotImplementedException();
        }
    }
}
