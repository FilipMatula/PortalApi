﻿using PortalApi.ResourceParameters;

namespace PortalApi.Validators
{
    public interface IResourceValidator
    {
        bool ValidArticlesParameters(ArticlesResourceParameters articlesResourceParameters);
        bool ValidPiercingsParameters(PiercingsResourceParameters piercingsResourceParameters);
        bool ValidTattoosParameters(TattoosResourceParameters tattoosResourceParameters);
        bool ValidModelsPhotosParameters(ModelsPhotosResourceParameters modelsPhotosResourceParameters);
        bool ValidPhotographersPhotosParameters(PhotographersPhotosResourceParameters photographersPhotosResourceParameters);
        bool ValidDesignsParameters(AvailableDesignsResourceParameters availableDesignResourceParameters);
    }
}