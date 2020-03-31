using System;
using System.Collections.Generic;
using PostComment;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;


namespace ObjectWCF
{
    [ServiceContract] interface InterfacePost
    {

        [OperationContract] bool AddPost(Post post);

        [OperationContract] Post GetPostById(int id);

        [OperationContract] int DeletePost(int id);
        
        [OperationContract] List<Post> GetPosts();

        [OperationContract] Post UpdatePost(Post post);

    }

    [ServiceContract] interface InterfaceComment
    {

        [OperationContract] bool AddComment(Comment comment);

        [OperationContract] Comment UpdateComment(Comment newComment);

        [OperationContract] Comment GetCommentById(int id);

    }

    [ServiceContract] interface IPostComment: InterfacePost, InterfaceComment{}

    class InterfaceWCF { }
      
}
