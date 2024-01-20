namespace Post.Command.Api.Commands {
    public interface ICommandHandler {
         Task HandleAsync(NewPostCommand command);
         Task HandleAsync(DeletePostCommand command);
         Task HandleAsync(AddCommentCommand command);
         Task HandleAsync(EditCommentCommand command);
         Task HandleAsync(RemoveCommentCommand command);
         Task HandleAsync(EditMessageCommand command);
         Task HandleAsync(LikePostCommand command);
    }
}