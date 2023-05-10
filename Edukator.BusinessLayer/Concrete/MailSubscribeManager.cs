using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class MailSubscribeManager : IMailSubscribeService
    {
        private readonly IMailSubscribeDal _mailSubscribeDal;
        public MailSubscribeManager(IMailSubscribeDal mailSubscribeDal)
        {
            _mailSubscribeDal = mailSubscribeDal;
        }
        public void TDelete(MailSubscribe t)
        {
            throw new NotImplementedException();
        }

        public MailSubscribe TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MailSubscribe> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(MailSubscribe t)
        {
            _mailSubscribeDal.Insert(t);
        }

        public void TUpdate(MailSubscribe t)
        {
            throw new NotImplementedException();
        }
    }
}
