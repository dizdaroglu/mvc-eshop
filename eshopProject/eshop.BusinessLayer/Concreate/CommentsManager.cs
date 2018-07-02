using eshop.BusinessLayer.Abstract;
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

        public int commentCount()
        {
            return _uow.CommentsDal.FindAll().Count();
        }

        public int commentCreate(Comments comment)
        {
            _uow.CommentsDal.Add(comment);
            return _uow.Complete();
        }

        public int commentsDelete(int id)
        {
            Comments find = _uow.CommentsDal.Find(m=>m.CommentId == id);

            _uow.CommentsDal.Remove(find);
            return _uow.Complete();
        }

        public Comments commentsDetails(int id)
        {
            return _uow.CommentsDal.Find(m => m.CommentId == id);
        }

        public int commentsUpdate()
        {
            return _uow.Complete();
        }

        public void DoComment(Comments comments)
        {
            _uow.CommentsDal.Add(comments);
            _uow.Complete();
        }

        public List<Comments> getComment()
        {
            return _uow.CommentsDal.FindAll();
        }
    }
}
