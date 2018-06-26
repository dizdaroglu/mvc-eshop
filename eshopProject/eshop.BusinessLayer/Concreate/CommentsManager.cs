﻿using eshop.BusinessLayer.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Concreate
{
    public class CommentsManager : ICommentServices
    {
        private IUnitOfWork _uow;
        public CommentsManager()
        {
            _uow = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public void DoComment(Comments comments)
        {
            _uow.CommentsDal.Add(comments);
            _uow.Complete();
        }
    }
}