﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LFA.Data.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LFABlogEntities : DbContext
    {
        public LFABlogEntities()
            : base("name=LFABlogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TempUser> TempUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int DeleteComment(Nullable<int> commentId)
        {
            var commentIdParameter = commentId.HasValue ?
                new ObjectParameter("CommentId", commentId) :
                new ObjectParameter("CommentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteComment", commentIdParameter);
        }
    
        public virtual int DeletePost(Nullable<int> postId)
        {
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePost", postIdParameter);
        }
    
        public virtual int DeleteRole(Nullable<int> roleId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteRole", roleIdParameter);
        }
    
        public virtual int DeleteUser(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", userIdParameter);
        }
    
        public virtual int InsertComment(string commentContent, Nullable<int> postId, Nullable<int> userId)
        {
            var commentContentParameter = commentContent != null ?
                new ObjectParameter("CommentContent", commentContent) :
                new ObjectParameter("CommentContent", typeof(string));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertComment", commentContentParameter, postIdParameter, userIdParameter);
        }
    
        public virtual int InsertPost(string postTitle, string postContent, Nullable<int> userId)
        {
            var postTitleParameter = postTitle != null ?
                new ObjectParameter("PostTitle", postTitle) :
                new ObjectParameter("PostTitle", typeof(string));
    
            var postContentParameter = postContent != null ?
                new ObjectParameter("PostContent", postContent) :
                new ObjectParameter("PostContent", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPost", postTitleParameter, postContentParameter, userIdParameter);
        }
    
        public virtual int InsertRoles(string roleName, string roleDesc)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var roleDescParameter = roleDesc != null ?
                new ObjectParameter("RoleDesc", roleDesc) :
                new ObjectParameter("RoleDesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertRoles", roleNameParameter, roleDescParameter);
        }
    
        public virtual int InsertUsers(string userName, string password, string email, Nullable<int> roleId)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUsers", userNameParameter, passwordParameter, emailParameter, roleIdParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateComment(Nullable<int> commentId, string commentContent, Nullable<int> userId, Nullable<int> postId)
        {
            var commentIdParameter = commentId.HasValue ?
                new ObjectParameter("CommentId", commentId) :
                new ObjectParameter("CommentId", typeof(int));
    
            var commentContentParameter = commentContent != null ?
                new ObjectParameter("CommentContent", commentContent) :
                new ObjectParameter("CommentContent", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateComment", commentIdParameter, commentContentParameter, userIdParameter, postIdParameter);
        }
    
        public virtual int UpdatePost(Nullable<int> postId, string postTitle, string postContent, Nullable<int> userId)
        {
            var postIdParameter = postId.HasValue ?
                new ObjectParameter("PostId", postId) :
                new ObjectParameter("PostId", typeof(int));
    
            var postTitleParameter = postTitle != null ?
                new ObjectParameter("PostTitle", postTitle) :
                new ObjectParameter("PostTitle", typeof(string));
    
            var postContentParameter = postContent != null ?
                new ObjectParameter("PostContent", postContent) :
                new ObjectParameter("PostContent", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePost", postIdParameter, postTitleParameter, postContentParameter, userIdParameter);
        }
    
        public virtual int UpdateRole(Nullable<int> roleId, string roleName, string roleDesc)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var roleDescParameter = roleDesc != null ?
                new ObjectParameter("RoleDesc", roleDesc) :
                new ObjectParameter("RoleDesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateRole", roleIdParameter, roleNameParameter, roleDescParameter);
        }
    
        public virtual int UpdateUser(Nullable<int> userId, string userName, string password, string email, Nullable<int> roleId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUser", userIdParameter, userNameParameter, passwordParameter, emailParameter, roleIdParameter);
        }
    }
}