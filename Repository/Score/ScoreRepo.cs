using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.Score
{
    public class ScoreRepo : IScoreRepo
    {
        private readonly IScoreService _scoreService;

        public ScoreRepo(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }
        public IEnumerable<ScoreDto> GetAll()
        {
            return _scoreService.GetAll().Select(x => new ScoreDto()
            {
                Id = x.Id,
                Accessibility = x.Accessibility,
                Facility = x.Facility,
                Quality = x.Quality,
                Service = x.Service,
                Value = x.Value,
                WeddingVenuesId = x.WeddingVenuesId

            });
        }

        public void Create(ScoreDto model)
        {
            var score = new Avenue.Core.Score()
            {
                Id = model.Id,
                Service = model.Service,
                Value = model.Value,
                WeddingVenuesId = model.WeddingVenuesId,
                Accessibility = model.Accessibility,
                Facility = model.Facility,
                Quality = model.Quality,

            };
            _scoreService.Create(score);
        }

        public void Edit(ScoreDto model)
        {
            var score = new Avenue.Core.Score()
            {
                Id = model.Id,
                Service = model.Service,
                Value = model.Value,
                WeddingVenuesId = model.WeddingVenuesId,
                Accessibility = model.Accessibility,
                Facility = model.Facility,
                Quality = model.Quality,

            };
            _scoreService.Update(score);
        }

        public void Delete(Guid id)
        {
            var score = _scoreService.GetById(id);
            _scoreService.Delete(score);
        }

        public ScoreDto Find(Guid id)
        {
            var score = _scoreService.Find(id);
            return new ScoreDto()
            {
                Id = score.Id,
                Facility = score.Facility,
                Quality = score.Quality,
                Accessibility = score.Accessibility,
                Service = score.Service,
                Value = score.Value,
                WeddingVenuesId = score.WeddingVenuesId
            };
        }
    }
}
