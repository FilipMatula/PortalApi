using PortalApi.ResourceParameters;

namespace PortalApi.Validators
{
    public interface IResourceValidator
    {
        bool ValidArticlesParameters(ArticlesResourceParameters articlesResourceParameters);
        bool ValidPiercingsParameters(PiercingsResourceParameters piercingsResourceParameters);
        bool ValidTattoosParameters(TattoosResourceParameters tattoosResourceParameters);
        bool ValidDesignsParameters(AvailableDesignPhotoResourceParameters availableDesignResourceParameters);
    }
}