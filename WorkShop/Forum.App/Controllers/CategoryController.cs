namespace Forum.App.Controllers
{
    using System;
    using System.Linq;
    using Forum.App.Controllers.Contracts;
    using Forum.App.Services;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Views;

    public class CategoryController : IController, IPaginationController
    {
        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        public CategoryController()
        {
            this.CurrentPage = 0;
            this.SetCategory(0);
        }

        public int CurrentPage { get; set; }

        private string[] PostTitles { get; set; }

        public int LastPage => this.PostTitles.Length / 11;

        public bool IsFirstPage => this.CurrentPage == 0;

        private bool IsLastPage => this.CurrentPage == this.LastPage;

        public int CategoryId { get; private set; }

        public void SetCategory(int categoryId)
        {
            this.CategoryId = categoryId;
        }
        
        public void ChangePage(bool foward = true)
        {
            this.CurrentPage += foward ? 1 : -1;
            GetPosts();
        }

        private void GetPosts()
        {
            var allCategoryPosts = PostService.GetPostByCategory(this.CategoryId);

            this.PostTitles = allCategoryPosts.Skip(PAGE_OFFSET).Select(p => p.Title).ToArray();
        }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Back:
                    return MenuState.Back;
                case Command.ViewPost:
                    return MenuState.ViewPost;
                case Command.PreviousPage:
                    return MenuState.OpenCategory;
                case Command.NextPage:
                    return MenuState.OpenCategory;
                default:
                    break;
            }
            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            GetPosts();
            string categoryName = PostService.GetCategory(this.CategoryId).Name;
            return new CategoryView(categoryName, this.PostTitles, this.IsFirstPage, this.IsLastPage);  
        }

        private enum Command
        {
            Back = 0,
            ViewPost = 1,
            PreviousPage = 11,
            NextPage = 12
        }
    }
}
