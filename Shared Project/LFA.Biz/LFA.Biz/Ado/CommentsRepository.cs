using LFA.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Biz.Ado
{
    public class CommentsRepository
    {
         DataAccess db;
         public CommentsRepository()
        {
            db = new DataAccess("Data Source=.;uid=sa;password=system;initial catalog=LFABlog;");
        }
        public List<Comment> GetAll()
        {
            SqlDataReader dr = db.ExecDataReader("SELECT * FROM dbo.Comments");
            List<Comment> lstComments = new List<Comment>();
            while (dr.Read())
            {
                Comment objComment = new Comment();
                objComment.CommentId = int.Parse(dr[0].ToString());
                objComment.CommentContent = dr[1].ToString();
                objComment.CreatedDate = DateTime.Parse(dr[2].ToString());
                objComment.UserId = int.Parse(dr[3].ToString());
                objComment.PostId = int.Parse(dr[4].ToString());
                lstComments.Add(objComment);
            }
            return lstComments;
        }
        public int Add(Comment objComment)
        {
            return db.ExecNonQueryProc("InsertComment", "@CommentContent", objComment.CommentContent, "@UserId", objComment.UserId, "@PostId", objComment.PostId);
        }
        public int Edit(Comment objComment)
        {
            return db.ExecNonQueryProc("UpdateComment", "@CommentId", objComment.CommentId, "@CommentContent", objComment.CommentContent, "@UserId", objComment.UserId, "@PostId", objComment.PostId);
        }
        public int Delete(int id)
        {
            return db.ExecNonQueryProc("DeleteComment", "@CommentId", id);
        }
    }
}
