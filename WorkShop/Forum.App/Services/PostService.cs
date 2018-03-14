using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Forum.App.UserInterface.ViewModels;

namespace Forum.App.Services
{
    public static class PostService
    {
        internal static Category GetCategory(int categoryId)
        {
            ForumData forumData = new ForumData();

            Category category = forumData.Categories.Find(u => u.Id == categoryId);

            return category;
        }
        internal static string[] GetAllCategoryNames()
        {
            ForumData forumData = new ForumData();

            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();

            return allCategories;
        }

        internal static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            ForumData forumData = new ForumData();

            Post post = forumData.Posts.Find(p => p.Id == postId);

            IList<ReplyViewModel> replies = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Find(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        public static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;
            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);

            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.Last().Id + 1 : 1;
                category = new Category(categoryId, categoryName, new List<int>());
                forumData.Categories.Add(category);

            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postView)
        {
            bool emptyCategory = string.IsNullOrWhiteSpace(postView.Category);
            bool emptyTitle = string.IsNullOrWhiteSpace(postView.Title);
            bool emptyContent = !postView.Content.Any();

            if (emptyCategory || emptyContent || emptyTitle)
            {
                return false;
            }

            var forumData = new ForumData();
            var category = EnsureCategory(postView, forumData);


            var postId = forumData.Posts.Last()?.Id + 1 ?? 1;
            var author = forumData.Users.Single(u => u.Username == postView.Author);
            string cotent = string.Join("", postView.Content);

            Post post = new Post(postId, postView.Title, cotent, category.Id, author.Id,new List<int>());

            forumData.Posts.Add(post);
            category.PostsIds.Add(postId);
            author.PostIds.Add(postId);
            author.PostIds.Add(postId);
            forumData.SaveChanges();
            return true;
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumData = new ForumData();

            Post post = forumData.Posts.Find(p => p.Id == postId);

            PostViewModel pvm = new PostViewModel(post);

            return pvm;
        }

        public static IEnumerable<Post> GetPostByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();

            var postIds = forumData.Categories.First(c => c.Id == categoryId).PostsIds;

            IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));

            return posts;
        }
    }

    
}
