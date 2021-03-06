using Microsoft.EntityFrameworkCore;
using Shop.Infrastructure.Data;
using Shop.Infrastructure.Helpers;
using Shop.Module.Core.Abstractions.Entities;
using Shop.Module.Core.Abstractions.Models;
using Shop.Module.Reviews.Abstractions.Data;
using Shop.Module.Reviews.Abstractions.Entities;
using Shop.Module.Reviews.Abstractions.Services;

namespace Shop.Module.Reviews.Data
{
    public class ReviewsCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            const string module = "Reviews";

            modelBuilder.Entity<Reply>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Review>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Support>().HasQueryFilter(c => !c.IsDeleted);

            modelBuilder.Entity<EntityType>().HasData(
                new EntityType() { Id = (int)EntityTypeWithId.Review, Name = EntityTypeWithId.Review.GetDisplayName(), Module = module, IsMenuable = false },
                new EntityType() { Id = (int)EntityTypeWithId.Reply, Name = EntityTypeWithId.Reply.GetDisplayName(), Module = module, IsMenuable = false }
                );

            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting(ReviewKeys.IsReviewAutoApproved) { Module = module, IsVisibleInCommonSettingPage = true, Value = "false", Type = typeof(bool).FullName },
                new AppSetting(ReviewKeys.IsReplyAutoApproved) { Module = module, IsVisibleInCommonSettingPage = true, Value = "true", Type = typeof(bool).FullName }
                );
        }
    }
}
