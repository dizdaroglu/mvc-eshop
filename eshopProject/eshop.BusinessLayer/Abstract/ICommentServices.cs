using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface ICommentServices
    {
        void DoComment(Comments comments);

       
#region Admin
        List<Comments> getComment();
        int commentCount();
        #endregion
        Comments commentsDetails(int id);
        int commentsUpdate();
        int commentsDelete(int id);
        int commentCreate(Comments comment);
    }
}
