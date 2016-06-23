using LFA.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Biz.Ado
{
    public class PostRepository
    {
        DataAccess db;
        public PostRepository()
        {
            db = new DataAccess("Data Source=.;uid=sa;password=system;initial catalog=LFABlog;");
        }
        public List<Post> GetAll()
        {
            SqlDataReader dr = db.ExecDataReader("SELECT * FROM dbo.Posts"); 
            List<Post> lstPosts = new List<Post>();            
            while (dr.Read()) 
            {
                Post objPost = new Post();
                objPost.PostId = int.Parse(dr[0].ToString());
                objPost.PostTitle = dr[1].ToString();
                objPost.PostCotent = dr[2].ToString();
                objPost.CreatedDate = DateTime.Parse(dr[3].ToString());
                objPost.UserId = int.Parse(dr[4].ToString());
                lstPosts.Add(objPost);
            }
            return lstPosts;
        }
        public int Add(Post objPost)
        {
            return db.ExecNonQueryProc("InsertPost", "@PostTitle", objPost.PostTitle, "@PostContent", objPost.PostCotent, "@UserId", objPost.UserId);
        }
        public int Edit(Post objPost)
        {
            return db.ExecNonQueryProc("UpdatePost", "@PostId", objPost.PostId, "@PostTitle", objPost.PostTitle, "@PostContent", objPost.PostCotent, "@UserId", objPost.UserId);
        }
        public int Delete(int id)
        {
            return db.ExecNonQueryProc("DeletePost", "@PostId", id);
        }
    }
}
