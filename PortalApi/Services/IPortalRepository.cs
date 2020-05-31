﻿using PortalApi.Entities;
using PortalApi.Helpers;
using PortalApi.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public interface IPortalRepository
    {
        #region Article's methods
        Task<IEnumerable<ArticleCategory>> GetArticlesCategories();
        Task<IEnumerable<Article>> GetArticlesByCategory(int subcategoryId, int amount);
        Task<PagedList<Article>> GetArticlesByCategory(int subcategoryId, ArticlesResourceParameters articlesResourceParameters);
        Task<Article> GetArticle(int articleId);
        
        #endregion

        #region Tattoo's methods
        Task<Tattoo> GetTattoo(int tattooId);
        Task<IEnumerable<Tattoo>> GetTattoos(int? amount);
        Task<PagedList<Tattoo>> GetTattoos(TattoosResourceParameters tattoosResourceParameters);

        #endregion

        #region Piercing's methods
        Task<Piercing> GetPiercing(int piercingId);
        Task<IEnumerable<Piercing>> GetPiercings(int amount);
        Task<PagedList<Piercing>> GetPiercings(PiercingsResourceParameters piercingsResourceParameters);
        #endregion

        #region Model's methods
        Task<Model> GetModel(int modelId);
        Task<IEnumerable<Model>> GetModels(int? amount);
        Task<PagedList<Model>> GetModels(ModelResourceParameters modelsResourceParameters);
        #endregion

        #region Photographer's methods
        Task<Photographer> GetPhotographer(int photographerId);
        Task<IEnumerable<Photographer>> GetPhotographers(int? amount);
        Task<PagedList<Photographer>> GetPhotographers(PhotographerResourceParameters photographerResourceParameters);
        #endregion
    }
}