using PortalApi.ResourceParameters;

namespace PortalApi.Validators
{
    public interface IResourceValidator
    {
        bool ValidArticlesParameters(ArticlesResourceParameters articlesResourceParameters);
        bool ValidPiercingsParameters(PiercingsResourceParameters piercingsResourceParameters);
        bool ValidTattoosParameters(TattoosResourceParameters tattoosResourceParameters);
        bool ValidModelsPhotosParameters(ModelsPhotosResourceParameters modelsPhotosResourceParameters);
        bool ValidPhotographersPhotosParameters(PhotographersPhotosResourceParameters photographersPhotosResourceParameters);
        bool ValidAvailableDesignsParameters(AvailableDesignsResourceParameters availableDesignResourceParameters);
        bool ValidPiercersProfilesParameters(PiercersProfilesResourceParameters piercersProfilesResourceParameters);
        bool ValidModelsProfilesParameters(ModelsProfilesResourceParameters modelsProfilesResourceParameters);
        bool ValidTattooersProfilesParameters(TattooersProfilesResourceParameters tattooersProfilesResourceParameters);
        bool ValidPhotographersProfilesParameters(PhotographersProfilesResourceParameters photographersProfilesResourceParameters);
    }
}