﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x=>x.RecevierMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetSendbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }


        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageRemove(Message message)
        {
            _messageDal.Delete(message);

        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
