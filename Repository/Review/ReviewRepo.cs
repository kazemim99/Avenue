using System;
using System.Collections.Generic;
using System.Linq;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.Review
{
    public class ReviewRepo : IReviewRepo
    {

        private readonly IReviewService _reviewService;

        public ReviewRepo(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IEnumerable<ReviewDto> GetAll()
        {
            return _reviewService.GetAll().Select(x => new ReviewDto()
            {
                Id = x.Id,
                Content = x.Content,
                UserId = x.UserId,
                AnswerId = x.AnswerId,
                DisLike = x.DisLike,
                Like = x.Like,
                Suggestion = x.Suggestion,
                UserIp = x.UserIp

            });

        }

        public void Create(ReviewDto model)
        {
            var review = new Avenue.Core.Review()
            {
                Id = model.Id,
                Suggestion = model.Suggestion,
                UserIp = model.UserIp,
                AnswerId = model.AnswerId,
                Content = model.Content,
                DisLike = model.DisLike,
                Like = model.Like,
                UserId = model.UserId
            };
            _reviewService.Create(review);
        }

        public void Edit(ReviewDto model)
        {
            var review = new Avenue.Core.Review()
            {
                Id = model.Id,
                Suggestion = model.Suggestion,
                UserIp = model.UserIp,
                AnswerId = model.AnswerId,
                Content = model.Content,
                DisLike = model.DisLike,
                Like = model.Like,
                UserId = model.UserId
            };
            _reviewService.Update(review);
        }

        public void Delete(Guid id)
        {
            var rivew = _reviewService.GetById(id);
            _reviewService.Delete(rivew);
        }

        public ReviewDto Find(Guid id)
        {
            var review = _reviewService.Find(id);
            return new ReviewDto
            {
                Id = review.Id,
                Content = review.Content,
                UserId = review.UserId,
                AnswerId = review.AnswerId,
                Suggestion = review.Suggestion,
                Like = review.Like,
                DisLike = review.DisLike,
                UserIp = review.UserIp
            };
        }
    }
}
